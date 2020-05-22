using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject Camera;
    void Start()
    {
        float x = PlayerPrefs.GetFloat("x");
        float y = PlayerPrefs.GetFloat("y");
        float z = PlayerPrefs.GetFloat("z");
        Debug.Log(x);
        Player.transform.position = new Vector3(x, y, z);
        float cx = PlayerPrefs.GetFloat("cx");
        float cy = PlayerPrefs.GetFloat("cy");
        Debug.Log(cx);
        Camera.transform.position = new Vector3(cx, cy, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
