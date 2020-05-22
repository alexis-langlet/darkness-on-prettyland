using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suivi : MonoBehaviour
{
    public GameObject Player;

    public Animator animator;
    private bool hisplayed = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!hisplayed)
        {
            Debug.Log("ciné");
            animator.SetBool("lancer", true);
            hisplayed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        gameObject.transform.position = new Vector3(0, -0.1f, -10);
        if (x>=0 && x < 0.77)
        {
            gameObject.transform.position = new Vector3(x, -0.1f, -10);
        }
        else if (x>=0.77 && x < 7.0)
        {
            gameObject.transform.position = new Vector3(0.77f, -0.1f, -10);
        }
        else if (x>=7 && x < 13.62)
        {
            gameObject.transform.position = new Vector3(13.62f, -0.1f, -10);
        }
        else if (x>=13.62 && x < 16)
        {
            gameObject.transform.position = new Vector3(x, -0.1f, -10);
        }
        else if (x>=16 && x < 22.53)
        {
            gameObject.transform.position = new Vector3(16, -0.1f, -10);
        }
        else if(x>=22.53 && x < 29.52)
        {
            gameObject.transform.position = new Vector3(29.52f, -0.1f, -10);
        }
        else if (x>=29.52 && x < 32)
        {
            gameObject.transform.position = new Vector3(x, -0.1f, -10);
        }
        else if(x>=32 && x < 38.7)
        {
            gameObject.transform.position = new Vector3(32, -0.1f, -10);
        }
        else if(x>=38.7 && x < 45.46)
        {
            gameObject.transform.position = new Vector3(45.46f, -0.1f, -10);
        }
        else if(x>=45.46 && x < 50.7)
        {
            gameObject.transform.position = new Vector3(x, -0.1f, -10);
        }
        else if (x>=50.7 && x<56.75)
        {
            gameObject.transform.position = new Vector3(50.7f, -0.1f, -10);
        }
        else if(x>=56.75 && x < 58.7)
        {
            gameObject.transform.position = new Vector3(x, -0.1f, -10);
        }
        else if (x >= 58.7)
        {
            gameObject.transform.position = new Vector3(58.7f, -0.1f, -10);
        }
    }    
}
