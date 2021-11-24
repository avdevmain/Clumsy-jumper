using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    [SerializeField]
    private Player player;


    private void FixedUpdate() {
        transform.Rotate(new Vector3(0,1,0), 45f * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        player.CollectCarrot();
        Destroy(gameObject);
    }

}
