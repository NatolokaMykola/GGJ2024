using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    public static float SmileMoney;
    
    private GameObject _moneyObject;
    
    public void Start()
    {
        if(PlayerPrefs.HasKey("SmileMoney"))
        {
            SmileMoney = PlayerPrefs.GetFloat("SmileMoney");
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SmileMoney"))
        {
            _moneyObject = other.gameObject;
            
            SmileMoney += 1;
            
            //PlayerPrefs.SetFloat("SmileMoney",SmileMoney);

            MoneyDelete();
        }
    }
    
    public void MoneyDelete()
    {
        _moneyObject.SetActive(false);
    }
    
}
