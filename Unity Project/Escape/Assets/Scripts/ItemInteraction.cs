using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public RaycastHit hit;
    public static bool HoldingObject, HoldingGlass, InventoryFull;
    public Transform Tab1, Tab2, Tab3, Tab4;

	// Use this for initialization
	void Start () {

        HoldingObject = false;
        HoldingGlass = false;
        InventoryFull = false;

    }
	
	// Update is called once per frame
	void Update ()

    {

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(ray, out hit, 20))
        {
            Debug.Log("hello");
            if (hit.collider.gameObject.GetComponent<Nine>() != null)
            {
                hit.collider.gameObject.GetComponent<Nine>().RotateStick();
                hit.collider.gameObject.GetComponent<Nine>().PosMonitor();
                hit.collider.gameObject.GetComponent<Nine>().ShowInteraction();
            }
                if (hit.collider.gameObject.GetComponent<ItemResponse>() !=null)
            {
                hit.collider.gameObject.GetComponent<ItemResponse>().ShowInteraction();
              

                if (hit.collider.gameObject.tag == "Glass")
                {
                    if (CharacterMovement.KeyboardMode == true)
                    {
                                if (Input.GetMouseButtonDown(0))
                        {
                        
                            if (HoldingGlass == false)
                                    {
                               
                                        HoldingGlass = true;
                                        
                                    }
                                    else
                                    {
                                
                                HoldingGlass = false;
                                       
                                    }
                                }
                       
                        hit.collider.gameObject.GetComponent<ItemResponse>().OnInteractionEnter();

                    }
                    if (CharacterMovement.GamepadMode == true)
                    {

                                if (Input.GetKeyDown(KeyCode.Joystick1Button0))
                                {
                   
                            if (HoldingGlass == false)
                                    {
                           
                                HoldingGlass = true;
                                       
                                    }
                                    else
                                    {
                            
                                HoldingGlass = false;
                                       
                                    }
                            hit.collider.gameObject.GetComponent<ItemResponse>().OnInteractionEnter();

                        }
                    }
                }
                else
                {
                    if (CharacterMovement.KeyboardMode == true)
                    {
                                if (Input.GetMouseButtonDown(0))
                                {
                          
                            if (HoldingObject == false)
                                    {
                              
                                HoldingObject = true;
                                    
                                    }
                                    else
                                    {
                             
                                HoldingObject = false;
                                       
                                    }
                            hit.collider.gameObject.GetComponent<ItemResponse>().OnInteractionEnter();
                        }
                    }
                    if (CharacterMovement.GamepadMode == true)
                    {
                                if (Input.GetKeyDown(KeyCode.Joystick1Button0))
                                {
                         
                            if (HoldingObject == false)
                            {
                         
                                HoldingObject = true;
                                    }
                                    else
                            {
                              
                                HoldingObject = false;
                                    }

                            hit.collider.gameObject.GetComponent<ItemResponse>().OnInteractionEnter();

                        }
                    }
                }
     
            }
           
        }

		
	}

    public void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.name == "Tablet1")
        {
            Tab1.position = new Vector3(-3000, 200, 1500);
            EscapeUI.crocfound = true;
        }
        if (collider.gameObject.name == "Tablet2")
        {
            Tab2.position = new Vector3(-3000, 200, 1500);
            EscapeUI.hippofound = true;
        }
        if (collider.gameObject.name == "Tablet3")
        {
            Tab3.position = new Vector3(-3000, 200, 1500);
            EscapeUI.scarabfound = true;
        }
        if (collider.gameObject.name == "Tablet4")
        {
            Tab4.position = new Vector3(-3000, 200, 1500);
            EscapeUI.catfound = true;
        }
    }
}
