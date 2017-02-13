using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlock : MonoBehaviour {

    private Animator animatorController;

    private void Start()
    {
        animatorController = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            animatorController.SetTrigger("Fall");
        }
    }
}
