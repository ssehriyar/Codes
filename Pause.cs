using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject menu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                menu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                menu.SetActive(false);
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void exit()
    {
        Application.Quit();
    }
}
