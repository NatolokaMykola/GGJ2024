using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCanvas : MonoBehaviour
{
    [SerializeField] private GameObject shopCanvas;
    [SerializeField] private GameObject menuCanvas;


    public void BackHandler(){
        shopCanvas.SetActive(false);
        menuCanvas.SetActive(true);
        
        

    }
}
