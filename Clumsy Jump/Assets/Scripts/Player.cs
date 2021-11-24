using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Player : MonoBehaviour
{

    [SerializeField]
    private Rigidbody torsoRb;

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
    private Button pause_bttn;

    [SerializeField]
    private GameObject winScreen;

    [SerializeField]
    private SimpleGroundCheck[] groundChecks;

    private int collectedCarrots = 0;

    public void CollectCarrot()
    {
        collectedCarrots+=1;
    }
    public void ProcessFinish()
    {
        Debug.Log("Level finished");
        //Also needs progress manager


        //To be moved into separate UI_Manager
        left_bttn.gameObject.SetActive(false);
        right_bttn.gameObject.SetActive(false);
        pause_bttn.gameObject.SetActive(false);

        winScreen.SetActive(true);

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


    public void SpringEffect(Vector3 direction)
    {
   
        //torsoRb.AddForce(direction * 300f, ForceMode.Impulse);
        torsoRb.velocity = direction * 100f;
        
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
