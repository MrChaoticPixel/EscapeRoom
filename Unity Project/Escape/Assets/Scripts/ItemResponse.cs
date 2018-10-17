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
    

	// Use this for initialization
	void Start () {
        BeingCarried = false;
        rend = GetComponent<MeshRenderer>();
     


    }
	
	// Update is called once per frame
	void Update () {
        

        if (BeingCarried == true)
        {
            Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        }
        else
        {
            Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>(), false);
        }
        resetselected();
    }

    public void OnLookEnter()
    {
      
        if (CharacterMovement.GamepadMode == true)
        {
            interactionmsg.text = "Press A to Interact";
        }
        if (CharacterMovement.KeyboardMode == true)
        {
            interactionmsg.text = "Click to Interact";
        }
        if (ItemInteraction.HoldingObject == false)
        {
            if (ItemInteraction.HoldingGlass == false)
            {
                rend.material = Selected;
                interactiontext.SetActive(true);
            }
        }

    }

    public void OnInteractionEnter()
    {
        if (ItemInteraction.InventoryFull == false)
        {
            if (ItemInteraction.HoldingObject == true)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = PlayrCam;
                BeingCarried = true;
                ItemInteraction.InventoryFull = true;
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
    public void resetselected()
    {
        rend.material = NotSelect;
        interactiontext.SetActive(false);
    }
}
