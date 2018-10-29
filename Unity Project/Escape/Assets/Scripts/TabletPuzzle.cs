using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletPuzzle : MonoBehaviour {

    public Transform Pos;
    public static bool Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9;
    public MeshRenderer rend;
    public Material NotSelect, Selected;
    public Text interactionmsg4;
    public GameObject interactiontext4;


    // Use this for initialization
    void Start () {

        rend = GetComponent<MeshRenderer>();
        NotSelect = rend.material;
        Pos = GetComponent<Transform>();
        Pos1 = true;
        Pos2 = true;
        Pos3 = true;
        Pos4 = true;
        Pos5 = true;
        Pos6 = true;
        Pos7 = true;
        Pos8 = true;
        Pos9 = false;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rend.material = NotSelect;
        interactionmsg4.enabled = false;
        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg4.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg4.text = "Click to Interact";
        }
    }

    public void ShowInteraction()
    {
        interactionmsg4.enabled = true;
        rend.material = Selected;
    }

    public void ChangePos()
    {
        if (CharacterMovement.KeyboardMode == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Pos1 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -118.69f);
                }
                if (Pos2 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -113.69f);
                }
                if (Pos3 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -108.69f);
                }
                if (Pos4 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -113.69f);
                }
                if (Pos5 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -118.69f);
                }
                if (Pos6 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -108.69f);
                }
                if (Pos7 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -113.69f);
                }
                if (Pos8 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -118.69f);
                }
                if (Pos9 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -108.69f);
                }

            }

        }

        if (CharacterMovement.GamepadMode == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
               
                if (Pos1 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -118.69f);
                }
                if (Pos2 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -113.69f);
                }
                if (Pos3 == false)
                {
                    Pos.position = new Vector3(-150.5f, 17.2f, -108.69f);
                }
                if (Pos4 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -113.69f);
                }
                if (Pos5 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -118.69f);
                }
                if (Pos6 == false)
                {
                    Pos.position = new Vector3(-150.5f, 22.2f, -108.69f);
                }
                if (Pos7 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -113.69f);
                }
                if (Pos8 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -118.69f);
                }
                if (Pos9 == false)
                {
                    Pos.position = new Vector3(-150.5f, 27.2f, -108.69f);
                }
            }

        }
    }

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "EmptyCol1")
        {
            Pos1 = true;
        }
        else
        {
            Pos1 = false;
        }
        if (collider.gameObject.name == "EmptyCol2")
        {
            Pos2 = true;
        }
        else
        {
            Pos2 = false;
        }
        if (collider.gameObject.name == "EmptyCol3")
        {
            Pos3 = true;
        }
        else
        {
            Pos3 = false;
        }
        if (collider.gameObject.name == "EmptyCol4")
        {
            Pos4 = true;
        }
        else
        {
            Pos4 = false;
        }
        if (collider.gameObject.name == "EmptyCol5")
        {
            Pos5 = true;
        }
        else
        {
            Pos5 = false;
        }
        if (collider.gameObject.name == "EmptyCol6")
        {
            Pos6 = true;
        }
        else
        {
            Pos6 = false;
        }
        if (collider.gameObject.name == "EmptyCol7")
        {
            Pos7 = true;
        }
        else
        {
            Pos7 = false;
        }

        if (collider.gameObject.name == "EmptyCol8")
        {
            Pos8 = true;
        }
        else
        {
            Pos8 = false;
        }

        if (collider.gameObject.name == "EmptyCol9")
        {
            Pos9 = true;
        }
        else
        {
            Pos9 = false;
        }

    }
    public void OnTriggerExit(Collider collider)
    {
   

    }
}
