using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyStendController : MonoBehaviour
{
    public GameObject TestEnemyCanvas;
    public GameObject TestEnemy;
    public GameObject TestStend;
    
    public void Update()
    {
        if (!TestEnemy.activeSelf)
        {
            TestEnemyCanvas.SetActive(false);
            TestStend.GetComponent<BoxCollider2D>().enabled = false;
            this.enabled = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TestEnemyCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        TestEnemyCanvas.SetActive(false);
    }
}
