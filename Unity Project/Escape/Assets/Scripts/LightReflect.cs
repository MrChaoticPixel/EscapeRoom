using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightReflect : MonoBehaviour {

    public GameObject LightRay;
    public Collider col;

	// Use this for initialization
	void Start ()
    {

        LightRay.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "LightSource")
        {
            if (ItemInteraction.HoldingGlass == true)
            {
                LightRay.SetActive(true);
            }
            else
            {
                LightRay.SetActive(false);
            }
          
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "LightSource")
        {
            LightRay.SetActive(false);
        }
    }
}
