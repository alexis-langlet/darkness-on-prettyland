using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saut : MonoBehaviour
{
    public Rigidbody2D rb;
    public float VitesseVerticale;

    private bool AuSol = false;

    public AudioSource KeyFall;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Z)) && AuSol)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity += new Vector2(0, VitesseVerticale);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sol"))
        {
            AuSol = true;
            KeyFall.Play();
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sol"))
        {
            AuSol = false;
        }
    }
}
