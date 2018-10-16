using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabletspawning : MonoBehaviour {

    public GameObject Tab1, Tab2, Tab3, Tab4, Tab5, Tab6, Tab7, Bridge1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        SpawnTab1();

    }

    public void SpawnTab1()
    {
        if (BridgeCrystal.SpawnTab1 == true)
        {
            Tab1.SetActive(true);
        }
    }
}
