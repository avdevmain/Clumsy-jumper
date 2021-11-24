using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringButton : MonoBehaviour
{

    public float cooldownTime;
    private Coroutine cooldown;

    private Animator animator;
    [SerializeField]
    private Player player;

    private void Start() {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if (cooldown != null) return;
        
        animator.SetTrigger("activate");
        player.SpringEffect(transform.up);

        cooldown = StartCoroutine(CooldownCorout());
    }

    private void OnTriggerExit(Collider other) {
        animator.ResetTrigger("activate");
    }

    IEnumerator CooldownCorout()
    {
        yield return new WaitForSecondsRealtime(cooldownTime);
        cooldown = null;
    }
}
