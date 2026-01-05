using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{


    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float fastSpeed = 20f;
   

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }
        void OnCollisionEnter2D(Collision2D other)
        {
            moveSpeed = slowSpeed;
        }
        void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag == "SpeedUp")
            {
                moveSpeed = fastSpeed;
            }
        }
        
    
}
