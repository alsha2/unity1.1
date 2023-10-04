using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public float speed = 20.0f ;
public float turnSpeed = 60.0f ;
public float horizontalInput; 
public float forwardInput; 

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput= Input.GetAxis("Vertical");
    

         // Here move the vehicle forward     
     transform.Translate(Vector3.forward*Time.deltaTime*forwardInput*speed);
      transform.Rotate(Vector3.up,turnSpeed*horizontalInput *Time.deltaTime);
    }
}
