using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scales : MonoBehaviour {

    public Transform ScaleArm, Plate;
    public static bool Object;

	// Use this for initialization
	void Start () {

        ScaleArm.eulerAngles = new Vector3(0, 0, 0);
        Plate = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        ScaleArm.position = ScaleArm.position;
        //Plate.position = Plate.position;
        if (Object == false)
        {
            ScaleArm.eulerAngles = new Vector3(0, 0, 0);
           //Plate.eulerAngles = new Vector3(0, 0, 0);
        }
	}

    public void OnCollisionStay(Collision collider)
    {
        if (collider.gameObject.tag == "WeightObject")
        {
            Object = true;
        }
    }
    public void OnCollisionExit(Collision collider)
    {
        if (collider.gameObject.tag == "WeightObject")
        {
            Object = false;
        }
    }
}
