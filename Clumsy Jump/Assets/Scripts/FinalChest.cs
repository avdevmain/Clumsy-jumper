using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChest : MonoBehaviour
{
 
    private Animator animator;
    [SerializeField]
    private Player player;

    private float cooldownTime = 0.45f;
    private Coroutine cooldown;

    private void Start() {
        animator = GetComponent<Animator>();
    }


private void OnTriggerEnter(Collider other) {
    
    animator.SetTrigger("activate");
    if (cooldown==null)
        cooldown = StartCoroutine(CooldownCorout());
    
}

    IEnumerator CooldownCorout()
    {
        yield return new WaitForSecondsRealtime(cooldownTime);
        player.ProcessFinish();
    }

}
