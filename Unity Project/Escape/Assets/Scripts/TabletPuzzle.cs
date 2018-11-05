using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletPuzzle : MonoBehaviour {

    public Transform Pos;
    public static bool Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9;
    public TabletPuzzle T1, T2, T3, T4, T5, T6, T7, T8;
    public bool canMov, correct;
    public bool in1, in2, in3, in4, in5, in6, in7, in8, in9;
    public MeshRenderer rend;
    public Material NotSelect, Selected, correctmat;
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
        in1 = false;
        in2 = false;
        in3 = false;
        in4 = false;
        in5 = false;
        in6 = false;
        in7 = false;
        in8 = false;
        in9 = false;
        T1 = GameObject.Find("PuzzleTab1").GetComponent<TabletPuzzle>();
        T2 = GameObject.Find("PuzzleTab2").GetComponent<TabletPuzzle>();
        T3 = GameObject.Find("PuzzleTab3").GetComponent<TabletPuzzle>();
        T4 = GameObject.Find("PuzzleTab4").GetComponent<TabletPuzzle>();
        T5 = GameObject.Find("PuzzleTab5").GetComponent<TabletPuzzle>();
        T6 = GameObject.Find("PuzzleTab6").GetComponent<TabletPuzzle>();
        T7 = GameObject.Find("PuzzleTab7").GetComponent<TabletPuzzle>();
        T8 = GameObject.Find("PuzzleTab8").GetComponent<TabletPuzzle>();
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

      if (T1.in8 == true)
        {
            T1.correct = true;
        }
      else
        {
            T1.correct = false;
        }
        if (T2.in7 == true)
        {
            T2.correct = true;
        }
        else
        {
            T2.correct = false;
        }
        if (T3.in2 == true)
        {
            T3.correct = true;
        }
        else
        {
            T3.correct = false;
        }
        if (T4.in5 == true)
        {
            T4.correct = true;
        }
        else
        {
            T4.correct = false;
        }
        if (T5.in3 == true)
        {
            T5.correct = true;
        }
        else
        {
            T5.correct = false;
        }
        if (T6.in1 == true)
        {
            T6.correct = true;
        }
        else
        {
            T6.correct = false;
        }
        if (T7.in6 == true)
        {
            T7.correct = true;
        }
        else
        {
            T7.correct = false;
        }
        if (T8.in9 == true)
        {
            T8.correct = true;
        }
        else
        {
            T8.correct = false;
        }
        if (correct == true)
        {
            rend.material = correctmat;
        }
        else
        {
            rend.material = NotSelect;
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
                if (canMov == true)
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

        if (CharacterMovement.GamepadMode == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                if (canMov == true)
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
    }

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "EmptyCol1")
        {
            Pos1 = true;
            in1 = true;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos2 == false || Pos5 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }
     
        if (collider.gameObject.name == "EmptyCol2")
        {
            Pos2 = true;
            in1 = false;
            in2 = true;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos1 == false || Pos4 == false || Pos3 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }

        if (collider.gameObject.name == "EmptyCol3")
        {
            Pos3 = true;
            in1 = false;
            in2 = false;
            in3 = true;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos2 == false || Pos6 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }

        if (collider.gameObject.name == "EmptyCol4")
        {
            Pos4 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = true;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos6 == false || Pos7 == false || Pos2 == false || Pos5 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }

        if (collider.gameObject.name == "EmptyCol5")
        {
            Pos5 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = true;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos1 == false || Pos4 == false || Pos8 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }

        if (collider.gameObject.name == "EmptyCol6")
        {
            Pos6 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = true;
            in7 = false;
            in8 = false;
            in9 = false;
            if (Pos9 == false || Pos3 == false || Pos4 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }

        if (collider.gameObject.name == "EmptyCol7")
        {
            Pos7 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = true;
            in8 = false;
            in9 = false;
            if (Pos4 == false || Pos8 == false || Pos9 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }


        if (collider.gameObject.name == "EmptyCol8")
        {
            Pos8 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = true;
            in9 = false;
            if (Pos5 == false || Pos7 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }


        if (collider.gameObject.name == "EmptyCol9")
        {
            Pos9 = true;
            in1 = false;
            in2 = false;
            in3 = false;
            in4 = false;
            in5 = false;
            in6 = false;
            in7 = false;
            in8 = false;
            in9 = true;
            if (Pos6 == false || Pos7 == false)
            {
                canMov = true;
            }
            else
            {
                canMov = false;
            }
        }


    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "EmptyCol1")
        {
            Pos1 = false;
        }

        if (collider.gameObject.name == "EmptyCol2")
        {
            Pos2 = false;
        }

        if (collider.gameObject.name == "EmptyCol3")
        {
            Pos3 = false;
        }

        if (collider.gameObject.name == "EmptyCol4")
        {
            Pos4 = false;
        }

        if (collider.gameObject.name == "EmptyCol5")
        {
            Pos5 = false;
        }

        if (collider.gameObject.name == "EmptyCol6")
        {
            Pos6 = false;
        }

        if (collider.gameObject.name == "EmptyCol7")
        {
            Pos7 = false;
        }


        if (collider.gameObject.name == "EmptyCol8")
        {
            Pos8 = false;
        }


        if (collider.gameObject.name == "EmptyCol9")
        {
            Pos9 = false;
        }

    }
}
