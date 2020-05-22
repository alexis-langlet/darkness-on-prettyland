using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPause = false;
    public GameObject PausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePlay();
        }
    }
    public void PausePlay()
        {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            PausePanel.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            PausePanel.SetActive(true);
        }
        }
}
