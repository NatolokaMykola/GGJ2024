using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SmileCanvasController : MonoBehaviour
{
    public GameObject Smilecanvas;
    
    public GameObject SmileInfocanvas;
    
    public GameObject Gamecanvas;

    public TextMeshProUGUI YouMoneyText;

    public GameObject Portal;
    

    public void Start()
    {
        if(PlayerPrefs.HasKey("SmileMoney"))
        {
            MoneyController.SmileMoney = PlayerPrefs.GetFloat("SmileMoney");
        }
    }
    
    public void Update()
    {
        YouMoneyText.text = MoneyController.SmileMoney.ToString() + "/45" ;

        if (MoneyController.SmileMoney == 45)
        {
            Portal.SetActive(true);
            

        }
    }

    public void BackHome()
    {
        SceneManager.LoadScene(0);
    }


    public void SmileInfoHandler()
    {
        SmileInfocanvas.SetActive(true);
    }

    public void SmileBackInfoHandler()
    {
        SmileInfocanvas.SetActive(false);
    }

    public void BackGameHandler()
    {
        Gamecanvas.SetActive(true);
        
        Smilecanvas.SetActive(false);
    }
}
