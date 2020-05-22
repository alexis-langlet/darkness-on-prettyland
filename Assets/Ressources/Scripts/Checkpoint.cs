using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public Vector3 checkpoint;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.gameObject.tag == "Checkpoint")
        {
            checkpoint = gameObject.transform.position;
            PlayerPrefs.SetFloat("x", gameObject.transform.position.x);
            PlayerPrefs.SetFloat("y", gameObject.transform.position.y);
            PlayerPrefs.SetFloat("z", gameObject.transform.position.z);
            PlayerPrefs.SetFloat("cx", Camera.transform.position.x);
            PlayerPrefs.SetFloat("cy", Camera.transform.position.y);
        }
    }
}
