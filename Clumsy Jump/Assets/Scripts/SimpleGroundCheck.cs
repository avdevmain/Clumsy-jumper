using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGroundCheck : MonoBehaviour
{

    public bool onGround;



 private void OnTriggerEnter(Collider other) {
    
    this.onGround = true;
 
 }

 private void OnTriggerExit(Collider other) {
    this.onGround = false;
 }

}
