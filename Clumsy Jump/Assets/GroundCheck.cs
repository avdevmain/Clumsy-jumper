using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private Animator animator;
  
    private void OnTriggerEnter(Collider other) {

        animator.SetTrigger("setLanding");


    }
}
