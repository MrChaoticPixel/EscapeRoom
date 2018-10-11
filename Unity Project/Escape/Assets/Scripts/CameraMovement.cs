﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public enum RotationAxis
    {
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    public float sensHorizontal = 10.0f;
    public float sensVertical = 10.0f;

    public float _rotationX = 0;
    public bool KeyboardMode, GamepadMode;

    // Use this for initialization
    void Start()
    {
        KeyboardMode = true;
        GamepadMode = false;
    }

        // Update is called once per frame
        void Update()
    {
        if (KeyboardMode == true)
        {
            if (axes == RotationAxis.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
            }
            else if (axes == RotationAxis.MouseY)
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
                _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //Clamps the vertical angle within the min and max limits (45 degrees)

                float rotationY = transform.localEulerAngles.y;

                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
        }
        if (GamepadMode == true)
        {
            if (axes == RotationAxis.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("JoyHorCam") * sensHorizontal, 0);
            }
            else if (axes == RotationAxis.MouseY)
            {
                _rotationX -= Input.GetAxis("JoyVerCam") * sensVertical;
                _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //Clamps the vertical angle within the min and max limits (45 degrees)

                float rotationY = transform.localEulerAngles.y;

                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
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