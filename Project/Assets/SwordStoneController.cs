using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordStoneController : MonoBehaviour
{
    public GameObject SwordPlayer;
    public GameObject StoneSword;
    public GameObject StoneCanvas;

    public bool ActivStone = false;
    void Start()
    {
        ActivStone = false;
        StoneCanvas.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ActivStone = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")&& (ActivStone == true))
        {
            StoneSword.SetActive(false);
            SwordPlayer.SetActive(true);
            this.enabled = false;
        }
        else if (other.CompareTag("Player"))
        {
            StoneCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        StoneCanvas.SetActive(false);
    }
}
