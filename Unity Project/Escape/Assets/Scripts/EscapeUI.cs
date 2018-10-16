using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeUI : MonoBehaviour {

    public Material Found, NotFound;
    public Image croc, hippo, fal, cat, scarab, snake, bab;
    public static bool crocfound, hippofound, falfound, catfound, scarabfound, snakefound, babfound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FoundTablets();


    }

    public void FoundTablets()
    {
        if (crocfound == true)
        {
            croc.material = Found;
        }

        if (hippofound == true)
        {
            hippo.material = Found;
        }

        if (falfound == true)
        {
            fal.material = Found;
        }

        if (catfound == true)
        {
            cat.material = Found;
        }

        if (scarabfound == true)
        {
            scarab.material = Found;
        }

        if (snakefound == true)
        {
            snake.material = Found;
        }

        if (babfound == true)
        {
            bab.material = Found;
        }
    }
}
