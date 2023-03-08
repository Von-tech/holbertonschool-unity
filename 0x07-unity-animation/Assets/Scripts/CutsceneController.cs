using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject player;
    public GameObject MainCamera;
    public GameObject TimerCanvas;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAnimatorEnd()
    {
        player.GetComponent<PlayerController>().enabled = true;
        TimerCanvas.SetActive(true);
        animator.enabled = false;
        gameObject.SetActive(false);
        MainCamera.SetActive(true);
    }
}
