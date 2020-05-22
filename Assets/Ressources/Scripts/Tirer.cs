using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tirer : MonoBehaviour
{
    [SerializeField]
    private Transform positionTir;

    [SerializeField]
    private GameObject luciole;
    private Vector2 directionSouris;
    private float angleSouris;
    public float vitesseLuciole = 15;
    public float vieLuciole = 15;
    public int compteurLucioles = 1;

    private bool tir = true;

    public Text compteurTexte;

    void Start()
    {
        modifierCompteur();
    }

    // Update is called once per frame
    void Update()
    {
        directionSouris = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angleSouris = Mathf.Atan2(directionSouris.y, directionSouris.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angleSouris);

        if (tir == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                compteurLucioles = compteurLucioles - 1;
                modifierCompteur();
                tirLuciole();
            }
        }
    }

    public void modifierCompteur()
    {
        compteurTexte.text = "Lucioles restantes : " + compteurLucioles.ToString();
        if (compteurLucioles == 0)
        {
            tir = false;
        }
        else
        {
            tir = true;
        }
    }

    private void tirLuciole()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        GameObject PlayerFeet = GameObject.FindGameObjectWithTag("Pied");
        GameObject lucioleEnvoyee = Instantiate(luciole, positionTir.position, positionTir.rotation);
        Physics2D.IgnoreCollision(lucioleEnvoyee.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(lucioleEnvoyee.GetComponent<Collider2D>(), PlayerFeet.GetComponent<Collider2D>());
        lucioleEnvoyee.GetComponent<Rigidbody2D>().velocity = positionTir.right * vitesseLuciole;

        StartCoroutine(dureeDeplacement(lucioleEnvoyee));
        StartCoroutine(dureeVieLuciole(lucioleEnvoyee));
    }

    private IEnumerator dureeDeplacement(GameObject luciole)
    {
        float distance = Mathf.Sqrt((directionSouris.x * directionSouris.x) + (directionSouris.y * directionSouris.y));
        float vitesse = Mathf.Sqrt((luciole.GetComponent<Rigidbody2D>().velocity.x * luciole.GetComponent<Rigidbody2D>().velocity.x) + (luciole.GetComponent<Rigidbody2D>().velocity.y * luciole.GetComponent<Rigidbody2D>().velocity.y));
        yield return new WaitForSeconds(distance / vitesse);
        luciole.GetComponent<Rigidbody2D>().velocity = positionTir.right * 0f;
    }

    private IEnumerator dureeVieLuciole(GameObject nouvelleLuciole)
    {
        yield return new WaitForSeconds(vieLuciole);
        Destroy(nouvelleLuciole);
    }
}
