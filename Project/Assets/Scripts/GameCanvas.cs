using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private GameObject pauseCanvas;

    public GameObject SmilesCanvas;
    
    public GameObject GamesCanvas;

    public static float StartCutScene = 0;

    public void Start()
    {
        if(PlayerPrefs.HasKey("StartCutScene"))
        {
            StartCutScene = PlayerPrefs.GetFloat("StartCutScene");
        }
        CutsceneManager.Instance.StartCutscene("CutSceneStartGame_1");
    }
    public void PauseHandler()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale=0f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
        StartCutScene = 2;
        PlayerPrefs.SetFloat("StartCutScene",StartCutScene);
    }

    public void SmileCanvas()
    {
        SmilesCanvas.SetActive(true);
        
        GamesCanvas.SetActive(false);
    }
}
