using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerVSAI()
    {
        SceneManager.LoadScene("PlayerVSAI");
    }

    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }
}
