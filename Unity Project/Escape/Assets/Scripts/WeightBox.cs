using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightBox : MonoBehaviour {

    public Rigidbody BoxRB;

	// Use this for initialization
	void Start () {

        BoxRB = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DestroyRope.RopeBurned == true)
        {
            BoxRB.constraints = RigidbodyConstraints.None;
        }
	}
}
