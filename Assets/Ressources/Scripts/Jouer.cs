using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jouer : MonoBehaviour
{
    public string Map;

    void Star()
    {
       PlayerPrefs.SetInt("load", 0);
    }

    public void LanceScene()
    {
        SceneManager.LoadScene(Map);
        PlayerPrefs.SetInt("load", 1);
        Time.timeScale = 1;
    }
}
