using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameCanvas gameCanvas;
    public void Start()
    {
        if(PlayerPrefs.HasKey("StartCutScene"))
        {
            GameCanvas.StartCutScene = PlayerPrefs.GetFloat("StartCutScene");
        }
    }

    public void StartHandler() 
    {
        if (GameCanvas.StartCutScene == 0)
        {
            SceneManager.LoadScene(1);
        }
        else if (GameCanvas.StartCutScene == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (GameCanvas.StartCutScene == 3)
        {
            SceneManager.LoadScene(3);
        }
    }
    
    public void BackShopHandler() 
    {
        SceneManager.LoadScene(0);
    }

    public void ExitHandler() 
    {
        Application.Quit();
    }

}
