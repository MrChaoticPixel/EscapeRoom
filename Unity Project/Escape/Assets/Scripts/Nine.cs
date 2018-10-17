using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nine : MonoBehaviour {

    public Text interactionmsg;
    public MeshRenderer rend;
    public Material NotSelect, Selected;
    public Transform StickTrans;
    public GameObject StickGO, interactiontext;
    public float PosNo;
    public bool Lookedat;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        StickGO = gameObject;
        StickTrans = GetComponent<Transform>();
        PosNo = 1;
        Lookedat = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        rend.material = NotSelect;
        interactiontext.SetActive(false);
        
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
        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg.text = "Click to Interact";
        }
        rend.material = Selected;
        interactiontext.SetActive(true);

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
}
