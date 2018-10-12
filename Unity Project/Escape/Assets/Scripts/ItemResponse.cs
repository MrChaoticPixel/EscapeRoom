using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemResponse : MonoBehaviour {

    public MeshRenderer rend;
    public Material NotSelect, Selected;
    public Text interactionmsg;
    public GameObject interactiontext;
    public Transform PlayrCam;
    public bool BeingCarried;
    

	// Use this for initialization
	void Start () {
        BeingCarried = false;
        rend = GetComponent<MeshRenderer>();
        interactiontext = GameObject.Find("InteractionMessage");
        interactionmsg = GameObject.Find("InteractionMessage").GetComponent<Text>();


    }
	
	// Update is called once per frame
	void Update () {

        rend.material = NotSelect;
        interactiontext.SetActive(false);
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
        if (ItemInteraction.HoldingObject == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = PlayrCam;
            BeingCarried = true;
        }
        if (ItemInteraction.HoldingObject == false)
        {
            rend.material = Selected;
            interactiontext.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            BeingCarried = false;
        }

    }
}
