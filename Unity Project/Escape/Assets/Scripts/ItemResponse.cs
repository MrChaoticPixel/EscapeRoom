using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemResponse : MonoBehaviour {

    public MeshRenderer rend;
    public Material NotSelect, Selected;
    public Text interactionmsg;
    public GameObject interactiontext, player;
    public Transform PlayrCam;
    public bool BeingCarried;
    public bool cannotstaff;
    

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        BeingCarried = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
            rend.material = NotSelect;
            interactionmsg.enabled = false;
        if (BeingCarried == true)
        {
            Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        }
        else
        {
            Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>(), false);
        }
        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg.text = "Click to Interact";
        }
    }

    public void OnInteractionEnter()
    {
        if (ItemInteraction.InventoryFull == false)
        {
            if (ItemInteraction.HoldingObject == true)
            {
                if (cannotstaff == false)
                {
                    GetComponent<Rigidbody>().isKinematic = true;
                    transform.parent = PlayrCam;
                    BeingCarried = true;
                    ItemInteraction.InventoryFull = true;
                }
             
            }
            if (ItemInteraction.HoldingGlass == true)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = PlayrCam;
                BeingCarried = true;
                ItemInteraction.InventoryFull = true;
            }
      
        }
        else
        {
            if (ItemInteraction.HoldingGlass == false)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                BeingCarried = false;
                ItemInteraction.InventoryFull = false;
            }
            if (ItemInteraction.HoldingObject == false)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                BeingCarried = false;
                ItemInteraction.InventoryFull = false;
            }

        }
     
    }
   

    public void ShowInteraction()
    {
        if (BeingCarried == false)
        {

            if (cannotstaff  == false)
            {
                interactionmsg.enabled = true;
                rend.material = Selected;
            }
        
        }
      
       
    }
}
