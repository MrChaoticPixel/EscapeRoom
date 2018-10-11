using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed;
    public bool canmov, KeyboardMode, GamepadMode;

    private Rigidbody rb;

    void Start()
    {
        canmov = true;
        KeyboardMode = true;
        GamepadMode = false;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        HandleMov();
    }
    public void HandleMov()
    {
        if (KeyboardMode == true)
        {
            if (canmov == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(Vector3.forward * (speed) * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(Vector3.left * (speed) * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(Vector3.back * (speed) * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.right * (speed) * Time.deltaTime);
                }
            }
        }
        if (GamepadMode == true)
        {
            if (canmov == true)
            {
                if (Input.GetAxis("JoyHor") == -1)
                {
                    transform.Translate(Vector3.left * (speed) * Time.deltaTime);
                }
                if (Input.GetAxis("JoyVer") == -1)
                {
                    transform.Translate(Vector3.forward * (speed) * Time.deltaTime);
                }
                if (Input.GetAxis("JoyVer") == 1)
                {
               
                    transform.Translate(Vector3.back * (speed) * Time.deltaTime);
                }
                if (Input.GetAxis("JoyHor") == 1)
                {
                 
                    transform.Translate(Vector3.right * (speed) * Time.deltaTime);
                }
            }
        }


    }
    public void ToggleGamepad(bool newValue)
    {
        if (KeyboardMode == true)
        {
            KeyboardMode = false;
            GamepadMode = true;
        }
        else
        {
            GamepadMode = false;
            KeyboardMode = true;
        }
    }
}
