using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
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
