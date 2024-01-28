using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private GameObject shopCanvas;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject levelCanvas;
    [SerializeField] private GameObject setingCanvas;


    public void ShopHandler(){
        menuCanvas.SetActive(false);
        shopCanvas.SetActive(true);
        

    }
    public void LevelHandler(){
        menuCanvas.SetActive(false);
        levelCanvas.SetActive(true);
        

    }
    public void SetingHandler(){
        menuCanvas.SetActive(false);
        setingCanvas.SetActive(true);
        

    }
}
