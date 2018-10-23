using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pillars : MonoBehaviour {

    public Text interactionmsg3;
    public MeshRenderer PillarMS;
    public Material NotS, Select, Active;
    public Transform PillarTrans;
    public GameObject interactiontext;
    public Pillars P1, P2, P3, P4, P5, P6;
    public float PillarPos;
    public static bool P1Active, P2Active, P3Active, P4Active, P5Active, P6Active;



    // Use this for initialization
    void Start () {

        PillarMS = GetComponent<MeshRenderer>();
        PillarTrans = GetComponent<Transform>();
        P1Active = false;
        P2Active = false;
        P3Active = false;
        P4Active = false;
        P5Active = false;
        P6Active = false;
        PillarPos = 1;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg3.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg3.text = "Click to Interact";
        }
        interactionmsg3.enabled = false;
        PillarMS.material = NotS;

        if (PillarPos == 5)
        {
            PillarPos = 1;
        }

        if (P1.PillarPos == 2)
        {
            GameObject.Find("RtationPillar1").GetComponent<MeshRenderer>().material = Active;
            P1Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar1").GetComponent<MeshRenderer>().material = NotS;
            P1Active = false;
        }

        if (P2.PillarPos == 4)
        {
            GameObject.Find("RtationPillar2").GetComponent<MeshRenderer>().material = Active;
            P2Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar2").GetComponent<MeshRenderer>().material = NotS;
            P2Active = false;
        }

        if (P3.PillarPos == 2)
        {
            GameObject.Find("RtationPillar3").GetComponent<MeshRenderer>().material = Active;
            P3Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar3").GetComponent<MeshRenderer>().material = NotS;
            P3Active = false;
        }

        if (P4.PillarPos == 1)
        {
            GameObject.Find("RtationPillar4").GetComponent<MeshRenderer>().material = Active;
            P4Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar4").GetComponent<MeshRenderer>().material = NotS;
            P4Active = false;
        }

        if (P5.PillarPos == 4)
        {
            GameObject.Find("RtationPillar5").GetComponent<MeshRenderer>().material = Active;
            P5Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar5").GetComponent<MeshRenderer>().material = NotS;
            P5Active = false;
        }

        if (P6.PillarPos == 3)
        {
            GameObject.Find("RtationPillar6").GetComponent<MeshRenderer>().material = Active;
            P6Active = true;
        }
        else
        {
            GameObject.Find("RtationPillar6").GetComponent<MeshRenderer>().material = NotS;
            P6Active = false;
        }


    }

    public void RotatePillars()
    {


        if (CharacterMovement.KeyboardMode == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //PillarTrans.eulerAngles = new Vector3(PillarTrans.rotation.x, PillarTrans.rotation.y+45, PillarTrans.rotation.z);
                PillarTrans.Rotate(Vector3.up * 45);
                PillarPos = PillarPos + 1;
            }

        }

        if (CharacterMovement.GamepadMode == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                // PillarTrans.eulerAngles = new Vector3(PillarTrans.rotation.x, PillarTrans.rotation.y + 45, PillarTrans.rotation.z);
                PillarTrans.Rotate(Vector3.up * 45);
                PillarPos = PillarPos + 1;

            }

        }
    }
    public void ShowInteraction()
    {
        Debug.Log("Hi There");
        interactionmsg3.enabled = true;
        PillarMS.material = Select;
    }
}
