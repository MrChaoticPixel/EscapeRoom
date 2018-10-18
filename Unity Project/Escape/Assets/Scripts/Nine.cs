using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nine : MonoBehaviour {

    public Text interactionmsg2;
    public MeshRenderer NineRend;
    public Material NotSelectNine, SelectedNine;
    public Transform StickTrans;
    public GameObject StickGO, interactiontext;
    public float PosNo;
    

	// Use this for initialization
	void Start () {
        NineRend = GetComponent<MeshRenderer>();
        StickGO = gameObject;
        StickTrans = GetComponent<Transform>();
        PosNo = 1;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg2.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg2.text = "Click to Interact";
        }

        NineRend.material = NotSelectNine;
        interactionmsg2.enabled = false;
    }

    public void PosMonitor()
    {
        if (CharacterMovement.KeyboardMode == true)
        {
            if (Input.GetMouseButton(0))
            {
                PosNo = PosNo + 1;
                if (PosNo == 9)
                {
                    PosNo = 1;
                }
            }

            }
        if (CharacterMovement.GamepadMode == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                PosNo = PosNo + 1;
                if (PosNo == 9)
                {
                    PosNo = 1;
                }
            }

        }
    }

    public void RotateStick()
    {
     

        if (CharacterMovement.KeyboardMode == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StickTrans.Rotate(Vector3.right * 45);
    
            }
      
        }

        if (CharacterMovement.GamepadMode == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                StickTrans.Rotate(Vector3.right * 45);

            }

        }
    }
    public void ShowInteraction()
    {
        Debug.Log("Hi There");
        interactionmsg2.enabled = true;
            NineRend.material = SelectedNine;
    }
}
