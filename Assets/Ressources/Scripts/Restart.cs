using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class Restart : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public GameObject PausePanel;

    void Start()
    {
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("x")) {
            //SceneManager.LoadScene("SampleScene");
            Thread t = new Thread(new ThreadStart(Scene));
            t.Start();
            float x = PlayerPrefs.GetFloat("x");
            float y = PlayerPrefs.GetFloat("y");
            float z = PlayerPrefs.GetFloat("z");
            Debug.Log(x);
            Player.transform.position = new Vector3(x, y, z);
            float cx = PlayerPrefs.GetFloat("cx");
            float cy = PlayerPrefs.GetFloat("cy");
            Debug.Log(cx);
            Camera.transform.position = new Vector3(cx, cy, -10);
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            SceneManager.LoadScene("Principal");
            Time.timeScale = 1;
        }
        
    }

    public void Scene()
    {
        SceneManager.LoadScene("Principal");
    }
}
