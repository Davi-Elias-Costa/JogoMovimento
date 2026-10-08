using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class pular : MonoBehaviour
{
    private bool OnTheGround = true;

    private Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    

    // Update is called once per frame
    void Update()
    {
        

       

            if (Keyboard.current.spaceKey.wasPressedThisFrame && OnTheGround == true)
            {
            rigidbody.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);

               // transform.position += 2f * Vector3.up;
            }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnTheGround = true;
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        OnTheGround = false;

    }
  
}
