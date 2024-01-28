using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetingCanvas : MonoBehaviour
{
    [SerializeField] private GameObject setingCanvas;
    [SerializeField] private GameObject menuCanvas;


    public void BackHandler(){

        setingCanvas.SetActive(false);
        
        menuCanvas.SetActive(true);
        
        
        

    }
}
