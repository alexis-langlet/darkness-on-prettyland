using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampadaire : MonoBehaviour
{
	private Transform position;
	public Light halo;
    public AudioSource lumiere;
    public GameObject lampeNuit;


    private bool hasplayed = false;
    // Start is called before the first frame update
    void Start()
    {
    	halo.range = 0.1f;
        gameObject.GetComponent<Renderer> ().enabled = false;
        lampeNuit.GetComponent<Renderer> ().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    	if(GameObject.FindWithTag("Player").transform.position.x - transform.position.x > -1){
        	gameObject.GetComponent<Renderer> ().enabled = true;
        	lampeNuit.GetComponent<Renderer> ().enabled = false;
        	halo.range = 5f;

            if (!hasplayed)
            {
                GameObject.FindWithTag("Pistolet").GetComponent<Tirer>().compteurLucioles += 2;
                GameObject.FindWithTag("Pistolet").GetComponent<Tirer>().modifierCompteur();
                lumiere.Play();
                hasplayed = true;
            }
            
    	}
    }
}
