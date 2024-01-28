using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsCanvas : MonoBehaviour
{
    [SerializeField] private GameObject levelCanvas;
    [SerializeField] private GameObject menuCanvas;


    public void BackHandler(){

        levelCanvas.SetActive(false);
        
        menuCanvas.SetActive(true);
    }
    public void Level1Handler(){

       SceneManager.LoadScene(1);
    }
    public void Level2Handler(){

        SceneManager.LoadScene(2);
    }
}
