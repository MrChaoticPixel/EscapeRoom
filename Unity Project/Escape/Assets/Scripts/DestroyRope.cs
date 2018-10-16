using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRope : MonoBehaviour {

    public static bool RopeBurned;

	// Use this for initialization
	void Start () {

        RopeBurned = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "LightReflection")
        {
            RopeBurned = true;
            Destroy(gameObject);

        }
    }
}
