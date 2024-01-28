using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutSceneCopibara : MonoBehaviour
{
    public GameObject PointStartCutScene;
    public GameObject CutScene;
    public GameObject Player;
    public GameObject Copibara;
    
    public Animator animator;
    private string floatParameter = "speedX";
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        AnimatorPlayer();
        CutScene.SetActive(true);
        CutsceneManager.Instance.StartCutscene("CutSceneLevel1Copibara");
        PointStartCutScene.GetComponent<BoxCollider2D>().enabled = false;
        Player.GetComponent<AttackController>().enabled = false;
        Player.GetComponent<PlayerController>().enabled = false;
        
    }

    public void EndCutSceneCopibara()
    {
        Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<AttackController>().enabled = true;
        Copibara.GetComponent<Animator>().enabled = false;
    }

    public void AnimatorPlayer()
    {
        animator.SetFloat(floatParameter,0);
    }
    
}
