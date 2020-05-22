using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurAmovible : MonoBehaviour
{
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.CompareTag("Player")) 
        {
            rb.velocity =  new Vector2(0, -10);
            GameObject.Find("mur").SetActive(false);
        }
    }
}
