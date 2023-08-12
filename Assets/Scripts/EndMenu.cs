using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    int sceneCount = SceneManager.sceneCountInBuildSettings;
    public void ReStartGame()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%sceneCount);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%sceneCount);
        }
    }
}
