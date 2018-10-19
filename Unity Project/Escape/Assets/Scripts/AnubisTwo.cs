using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubisTwo : MonoBehaviour {
    public GameObject loststaff;
    public Transform loststafftrans, AnuTwo;
    public ItemResponse loststaff1;
    public static bool Reunited;


    // Use this for initialization
    void Start () {
        Reunited = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionStay(Collision collider)
    {
        if (collider.gameObject.name == "Staff1")
        {
            loststaff.transform.parent = null;
            loststafftrans.parent = AnuTwo;
            loststafftrans.position = (new Vector3(339/10, 400/10, -2400/11));
            loststafftrans.eulerAngles = new Vector3(0, 0, 0);
            loststaff.GetComponent<Rigidbody>().isKinematic = true;
            Reunited = true;
            loststaff1.cannotstaff = true;



        }
    }
}
