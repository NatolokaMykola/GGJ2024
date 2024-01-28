using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevelScreen : MonoBehaviour
{
    public void NextLevelHandler() {

       Scene scene = SceneManager.GetActiveScene();
       Time.timeScale = 1f;
       
       SceneManager.LoadScene(scene.buildIndex +1);

           
    }
    public void RestartHandler() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1f;
        
    }

    public void ExitMenuHandler() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;    
           
    }
}
