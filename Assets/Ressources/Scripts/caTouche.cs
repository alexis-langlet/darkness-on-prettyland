using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caTouche : MonoBehaviour
{
    public Rigidbody2D licorne;
    public Rigidbody2D detecte;
    public float VitesseHorizontale;
    public float range;
    public bool flip;

    public Animator animator;
    public AudioSource henis;
    public AudioSource galop;

    private bool hasplayed = false;
    private int dir = -20;
    private float pos = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (flip)
        {
            dir = -1 * dir;
            pos = -1 * pos;
            detecte.transform.position = new Vector2(licorne.transform.position.x + pos, licorne.transform.position.y);
        }
        else
        {
            VitesseHorizontale = -1 * VitesseHorizontale;
            detecte.transform.position = new Vector2(licorne.transform.position.x + pos, licorne.transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {        
        detecte.velocity = new Vector2(dir, 0);

        if(Mathf.Abs(detecte.transform.position.x - licorne.transform.position.x) > range)
        {
            detecte.transform.position = new Vector2(licorne.transform.position.x + pos, licorne.transform.position.y);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player")) 
        {
            licorne.velocity += new Vector2(VitesseHorizontale, 0);
            detecte.transform.position = new Vector2(licorne.transform.position.x + pos, licorne.transform.position.y) ;
            animator.SetBool("vue", true);

            if (!hasplayed)
            {
                henis.Play();
                hasplayed = true;
            }
            galop.Play();
        }
        else
        {
            detecte.transform.position = new Vector2(licorne.transform.position.x + pos, licorne.transform.position.y);
            animator.SetBool("vue", false);
        }
    }

}


