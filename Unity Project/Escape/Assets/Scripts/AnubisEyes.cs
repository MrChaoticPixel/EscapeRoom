using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubisEyes : MonoBehaviour {

    public GameObject staff;
    public float TimetoBlind;
    public MeshRenderer AnuRen;
    public Material Mat1, Mat2;
    public bool drop;

    // Use this for initialization
    void Start () {
        AnuRen = GetComponent<MeshRenderer>();
        drop = false;
        TimetoBlind = 3;
        AnuRen.material = Mat1;
    }
	
	// Update is called once per frame
	void Update () {
        if (TimetoBlind < 0)
        {
            TimetoBlind = 0;
        }
        if (TimetoBlind == 0)
        {

            drop = true;
        }

        if (drop == true)
        {
            staff.GetComponent<Rigidbody>().isKinematic = false;
            staff.transform.parent = null;
            staff = null;
            AnuRen.material = Mat2;
        }
    }
    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "LightReflection")
        {
            TimetoBlind = TimetoBlind - Time.deltaTime;
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "LightReflection")
        {
            if (TimetoBlind < 3)
            {
                TimetoBlind = 3;
            }

        }
    }
}
