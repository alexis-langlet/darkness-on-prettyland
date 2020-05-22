using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boo : MonoBehaviour
{
	public Rigidbody2D rb;
	public float Vitesse;
	public bool passe;
	public Light halo;

	public AudioSource intro;

	private Vector2 direction;
	private float angle;

	private Transform position;
	

    // Start is called before the first frame update
	void Start()
	{
		halo.range = 0.1f;
		passe = false;
		gameObject.GetComponent<Renderer> ().enabled = false;
	}

    // Update is called once per frame
	void Update()
	{
		direction = GameObject.FindWithTag("Player").transform.position - transform.position;
		angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		
		if (angle>-90 && angle<90){
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
		}
		else {			
		transform.rotation = Quaternion.Euler(0f, 180f, 180-angle);
		}

		if(!passe && direction.x > 2){
			passe = true;
			gameObject.GetComponent<Renderer> ().enabled = true;
			halo.range = 1.1f;
			intro.Play();
		}

		if(passe){

			float dirX = Mathf.Sqrt(Mathf.Abs(direction.x))* Mathf.Abs(direction.x)/direction.x;
			float dirY = Mathf.Sqrt(Mathf.Abs(direction.y))* Mathf.Abs(direction.y)/direction.y;

			rb.velocity =  new Vector2(dirX * Vitesse, dirY * Vitesse);

		}
		if(passe && Mathf.Abs(direction.x)<0.6 && Mathf.Abs(direction.y)<1){
			SceneManager.LoadScene("Mort");
		}
	}
}

