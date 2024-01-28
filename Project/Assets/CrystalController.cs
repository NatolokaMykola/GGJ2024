using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalController : MonoBehaviour
{
    private GameCanvas gameCanvas;
    
    public bool ActivCrystal = false;
    
    public void Start()
    {
        if(PlayerPrefs.HasKey("StartCutScene"))
        {
            GameCanvas.StartCutScene = PlayerPrefs.GetFloat("StartCutScene");
        }
        ActivCrystal = false;
    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ActivCrystal = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && (ActivCrystal == true))
        {
            SceneManager.LoadScene(3);

            GameCanvas.StartCutScene = 3;
            
            PlayerPrefs.SetFloat("StartCutScene",GameCanvas.StartCutScene);
        }
    }
}
