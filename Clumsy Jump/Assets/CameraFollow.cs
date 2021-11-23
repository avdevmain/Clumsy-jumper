using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Hello brackeys!

    public Transform target;

    public float smoothSpeed = 12.5f;
    public Vector3 offset;



    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        
        if ((smoothedPosition.x < -13.5f) || (smoothedPosition.x > 13.5f)) //Level border values
            smoothedPosition.x = transform.position.x;

        if ((smoothedPosition.y < -6f)||(smoothedPosition.y > 18.5f))
            smoothedPosition.y = transform.position.y;

        
        transform.position = smoothedPosition;
    }
}