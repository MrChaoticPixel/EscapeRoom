using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCrystal : MonoBehaviour {

    public float TimetoChange;
    public bool change1, change2, tochange;
    public GameObject Bridge1, Bridge2;
    public MeshRenderer MRCrystal;
    public Material Mat1, Mat2, Mat3, Mat4;
    public static bool SpawnTab1;

	// Use this for initialization
	void Start () {
        MRCrystal = GetComponent<MeshRenderer>();
        change1 = false;
        change2 = true;
        TimetoChange = 5;
        tochange = false;
        SpawnTab1 = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (TimetoChange < 0)
        {
            TimetoChange = 0;
        }
        if (TimetoChange == 0)
        {
            Invoke("WaitABit", 1);
            tochange = true;
        
        }

        if (change2 == true)
        {
            Bridge2.SetActive(true);
            Bridge1.SetActive(false);

            if (TimetoChange == 5)
            {
                MRCrystal.material = Mat1;
            }

            if (TimetoChange < 4.5f && TimetoChange > 2.5f)
            {
                MRCrystal.material = Mat2;
            }
            if (TimetoChange <2.5f && TimetoChange>0)
            {
                MRCrystal.material = Mat3;
            }
            if (TimetoChange == 0)
            {
                MRCrystal.material = Mat4;
            }

        }
        else
        {
            Bridge2.SetActive(false);
            Bridge1.SetActive(true);
            if (TimetoChange == 5)
            {
                MRCrystal.material = Mat4;
            }

            if (TimetoChange < 4.5f && TimetoChange > 2.5f)
            {
                MRCrystal.material = Mat3;
            }
            if (TimetoChange < 2.5f && TimetoChange > 0)
            {
                MRCrystal.material = Mat2;
            }
            if (TimetoChange == 0)
            {
                MRCrystal.material = Mat1;
            }

        }
		
	}

    public void WaitABit()
    {
        TimetoChange = 5;
        if (tochange == true)
        {
            if (change1 == false)
            {
                SpawnTab1 = true;
                change1 = true;
                change2 = false;
                tochange = false;
            }
            else
            {
                change1 = false;
                change2 = true;
                tochange = false;
            }
        }
   
    }

    public void OnTriggerStay(Collider collider)
    {
       if (collider.gameObject.tag == "LightReflection")
        {
            TimetoChange = TimetoChange - Time.deltaTime;
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "LightReflection")
        {
            if (TimetoChange < 5)
            {
                TimetoChange = 5;
            }
           
        }
    }
}
