using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torches : MonoBehaviour {

    public Rigidbody TorRB;
    public Transform TorTrans, Holder1, Holder2, Holder3, Holder4, Holder5, Holder6;
    public TorchHolders HolderOne, HolderTwo, HolderThree, HolderFour, HolderFive, HolderSix;
    public bool In1, In2, In3, In4, In5, In6;

	// Use this for initialization
	void Start () {
        TorRB = GetComponent<Rigidbody>();
        TorTrans = GetComponent<Transform>();
        TorRB.isKinematic = true;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider collider)
    {
       
        if (collider.gameObject.name == "TorchHolderOne")
        {
            if (ItemInteraction.HoldingObject == false)
            {
                if (HolderOne.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder1;
                    TorTrans.position = Holder1.position;
                    TorTrans.eulerAngles = Holder1.eulerAngles;
                    In1 = true;
                    HolderOne.HasTorch = true;
                }
            }
        }
        if (collider.gameObject.name == "TorchHolderTwo")
        {
            if (ItemInteraction.HoldingObject == false)
            {
                if (HolderTwo.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder2;
                    TorTrans.position = Holder2.position;
                    TorTrans.eulerAngles = Holder2.eulerAngles;
                    In2 = true;
                    HolderTwo.HasTorch = true;
                }
            }
        }
        if (collider.gameObject.name == "TorchHolderThree")
        {
            if (ItemInteraction.HoldingObject == false)
            {
                if (HolderThree.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder3;
                    TorTrans.position = Holder3.position;
                    TorTrans.eulerAngles = Holder3.eulerAngles;
                    In3 = true;
                    HolderThree.HasTorch = true;
                }
            }
        }
        if (collider.gameObject.name == "TorchHolderFour")
        {
            if (ItemInteraction.HoldingObject == false)
            {
                if (HolderFour.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder4;
                    TorTrans.position = Holder4.position;
                    TorTrans.eulerAngles = Holder4.eulerAngles;
                    In4 = true;
                    HolderFour.HasTorch = true;
                }
            }

        }
        if (collider.gameObject.name == "TorchHolderFive")
        {
            if (ItemInteraction.HoldingObject == false)
            {
                if (HolderFive.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder5;
                    TorTrans.position = Holder5.position;
                    TorTrans.eulerAngles = Holder5.eulerAngles;
                    In5 = true;
                    HolderFive.HasTorch = true;
                }
            }
        }
        if (collider.gameObject.name == "TorchHolderSix")
        {
            if (ItemInteraction.HoldingObject == false)
            {

                if (HolderSix.HasTorch == false)
                {
                    TorRB.isKinematic = true;
                    TorTrans.parent = Holder6;
                    TorTrans.position = Holder6.position;
                    TorTrans.eulerAngles = Holder6.eulerAngles;
                    In6 = true;
                    HolderSix.HasTorch = true;
                }

            }
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "TorchHolder")
        {
            In1 = false;
            In2 = false;
            In3 = false;
            In4 = false;
            In5 = false;
            In6 = false;
        }

        }


}
