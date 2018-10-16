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
    public bool Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        StickGO = gameObject;
        StickTrans = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        rend.material = NotSelect;
        interactiontext.SetActive(false);
        PosMonitor();
    }

    public void PosMonitor()
    {
        if (StickTrans.rotation.x < 47 && StickTrans.rotation.x > 43)
        {
            Pos8 = true;
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
