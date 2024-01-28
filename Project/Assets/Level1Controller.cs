using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Controller : MonoBehaviour
{
    
    void Start()
    {
        CutsceneManager.Instance.StartCutscene("CutSceneLevel1");
    }
    
    void Update()
    {
        
    }
}
