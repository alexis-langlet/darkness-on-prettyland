using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Luciole;
    public GameObject PointLight;

    public AudioSource HorribleMort;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            Luciole.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            PointLight.GetComponent<Light>().range = 10;
        }
    }
}
