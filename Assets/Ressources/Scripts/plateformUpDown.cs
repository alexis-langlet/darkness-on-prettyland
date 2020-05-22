using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformUpDown : MonoBehaviour
{
	public Rigidbody2D rb;
	public float vitesse;
	public float heightMax;
	private float heightMin;
	private bool monte;
    // Start is called before the first frame update
    void Start()
    {
    	heightMin = rb.transform.position.y;
        monte = true;
        rb.velocity =  new Vector2(0, vitesse);
    }

    // Update is called once per frame
    void Update()
    {

        if (monte && rb.transform.position.y - heightMin >= heightMax){
        	rb.velocity =  new Vector2(0, -vitesse);
        	monte=false;
        }
        if (!monte && rb.transform.position.y <= heightMin){
        	rb.velocity =  new Vector2(0, vitesse);
        	monte=true;
        }


    }
}
