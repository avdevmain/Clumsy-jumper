using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringButton : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private Player player;

    private void Start() {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        animator.SetTrigger("activate");
        player.SpringEffect(transform.up);
    }

    private void OnTriggerExit(Collider other) {
        animator.ResetTrigger("activate");
    }
}
