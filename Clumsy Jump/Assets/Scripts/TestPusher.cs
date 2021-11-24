using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPusher : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private Collider pushcollider;

    Vector3 m_EulerAngleVelocity;

    private void Start() {
        pushcollider = GetComponent<Collider>();

        m_EulerAngleVelocity = new Vector3(-50, 0, 0);
    }

    private void Update() {
        //Debug.Log(Input.GetAxis("Horizontal"));

          Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
     private void OnCollisionEnter(Collision collision) {
        
        Debug.Log("A?AA??A");
        //pushcollider.enabled = false;

        ContactPoint[] contact =  collision.contacts;
        //contact[0].point;


        Vector3 dir =  (contact[0].point - rb.transform.position).normalized;
        rb.AddForce(dir * 25f, ForceMode.Impulse);

        pushcollider.enabled = false;

        
    }


    
}
