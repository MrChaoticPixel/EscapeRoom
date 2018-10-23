using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchHolders : MonoBehaviour {

    public bool HasTorch;
    public MeshRenderer THMR;
    public Material Active, NotActive;
    public GameObject Holder;
    public Torches Tor1, Tor2, Tor3, Tor4, Tor5, Tor6;
    public static bool HolActive1, HolActive2, HolActive3, HolActive4, HolActive5, HolActive6;


    // Use this for initialization
    void Start () {
        THMR = GetComponent<MeshRenderer>();
        HasTorch = true;
        Holder = gameObject;
        THMR.material = NotActive;
    }
	
	// Update is called once per frame
	void FixedUpdate () {


        CorrectTorches();
        ChangeMats();

    }
  
    public void CorrectTorches()
    {
        if (Tor1.In3 == true)
        {
            HolActive3 = true;
        }
        if (Tor2.In1 == true)
        {
            HolActive1 = true;
        }
        if (Tor3.In5 == true)
        {
            HolActive5 = true;
        }
        if (Tor4.In6 == true)
        {
            HolActive6 = true;
        }
        if (Tor5.In2 == true)
        {
            HolActive2 = true;
        }
        if (Tor6.In4 == true)
        {
            HolActive4 = true;
        }
    }
    public void ChangeMats()
    {
        if (HolActive6 == true)
        {
            GameObject.Find("TorchHolderSix").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderSix").GetComponent<MeshRenderer>().material = NotActive;
        }
        if (HolActive5 == true)
        {
            GameObject.Find("TorchHolderFive").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderFive").GetComponent<MeshRenderer>().material = NotActive;
        }
        if (HolActive4 == true)
        {
            GameObject.Find("TorchHolderFour").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderFour").GetComponent<MeshRenderer>().material = NotActive;
        }
        if (HolActive3 == true)
        {
            GameObject.Find("TorchHolderThree").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderThree").GetComponent<MeshRenderer>().material = NotActive;
        }
        if (HolActive2 == true)
        {
            GameObject.Find("TorchHolderTwo").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderTwo").GetComponent<MeshRenderer>().material = NotActive;
        }
        if (HolActive1 == true)
        {
            GameObject.Find("TorchHolderOne").GetComponent<MeshRenderer>().material = Active;
        }
        else
        {
            GameObject.Find("TorchHolderOne").GetComponent<MeshRenderer>().material = NotActive;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Torch")
        {
            HasTorch = false;
        }

    }
}
