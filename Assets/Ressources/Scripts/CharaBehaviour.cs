using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    public float VitesseHorizontale;
    private bool AuSol = false;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(VitesseHorizontale, rb.velocity.y);
            animator.SetInteger("status", 5);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity = new Vector2(-VitesseHorizontale, rb.velocity.y);
            animator.SetInteger("status", -5);
        }

        if(!(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D)))
        { 
            animator.SetInteger("status", 0);
        }
    }    

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Monstre")){
            SceneManager.LoadScene("Mort");
        }
    }
}
