using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public Animator wallanim;
    public MeshRenderer PressureRen;
    public Material On, Off;


	// Use this for initialization
	void Start () {
        wallanim.Play("WallTurn2");
        PressureRen = GetComponent<MeshRenderer>();
        PressureRen.material = Off;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Character")
        {
            PressureRen.material = On;
            wallanim.Play("WallTurn1");
        }
        if (collider.gameObject.tag == "WeightBox")
        {
            PressureRen.material = On;
            wallanim.Play("WallTurn1");
        }
    }
    public void OnCollisionExit(Collision collider)
    {
        if (collider.gameObject.tag == "Character")
        {
            PressureRen.material = Off;
            wallanim.Play("WallTurn2");
        }
        if (collider.gameObject.tag == "WeightBox")
        {
            PressureRen.material = Off;
            wallanim.Play("WallTurn2");
        }
    }
    public void OnCollisionStay(Collision collider)
    {
        if (collider.gameObject.tag == "Character")
        {
            PressureRen.material = On;
            wallanim.Play("WallTurn1");
        }
        if (collider.gameObject.tag == "WeightBox")
        {
            PressureRen.material = On;
            wallanim.Play("WallTurn1");
        }
    }
}
