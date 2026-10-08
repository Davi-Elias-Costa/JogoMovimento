using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class pular : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            transform.position += Time.deltaTime * 750 * Vector3.up;
        }

    }





}
