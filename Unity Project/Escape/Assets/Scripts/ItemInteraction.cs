using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public RaycastHit hit;
    public static bool HoldingObject, HoldingGlass, InventoryFull;

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

            if (hit.collider.gameObject.GetComponent<ItemResponse>() !=null)
            {
                hit.collider.gameObject.GetComponent<ItemResponse>().OnLookEnter();

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
}
