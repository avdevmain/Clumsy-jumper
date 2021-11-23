using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField]
    private Rigidbody[] rb;

    [SerializeField]
    private Rigidbody[] legsrb;

    [SerializeField]
    private Rigidbody[] armsrb;

    

    public bool onGround = false;


    [SerializeField]
    private Button left_bttn;
    
    [SerializeField]
    private Button right_bttn;

    [SerializeField]
    private SimpleGroundCheck[] groundChecks;

    private void Start() {
        rb = GetComponentsInChildren<Rigidbody>();
        
    }

    private bool IsOnGround()
    {
        bool result = false;
        foreach(SimpleGroundCheck check in groundChecks)
        {
            if (check.onGround) result = true;
        }

        return result;
    }

    public void LeftBttn()
    {
        
        //If Hands touch ground!
        if (!IsOnGround()) return;

        foreach (Rigidbody rigidbody in armsrb)
        {
            rigidbody.AddForce(new Vector3(0,0.65f,-0.5f) * 40f * rigidbody.mass, ForceMode.Impulse);
        }
    }

    public void RightBttn()
    {

        if (!IsOnGround()) return;
         //If legs touch ground!


        foreach (Rigidbody rigidbody in legsrb)
        {
            rigidbody.AddForce(new Vector3(0,0.65f,0.5f) * 60f * rigidbody.mass, ForceMode.Impulse);
        }
    }


    
    
}
