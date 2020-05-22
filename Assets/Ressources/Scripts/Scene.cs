using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public string Map;
    public void LanceScene()
    {
        SceneManager.LoadScene(Map);
    }
}
