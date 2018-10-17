using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabletspawning : MonoBehaviour {

    public GameObject Tab1, Tab2, Tab3, Tab4, Tab5, Tab6, Tab7, Bridge1;
    public Nine Stick1, Stick2, Stick3, Stick4, Stick5, Stick6, Stick7, Stick8, Stick9, Stick10, Stick11;
    public bool Stick1On, Stick2On, Stick3On, Stick4On, Stick5On, Stick6On, Stick7On, Stick8On, Stick9On, Stick10On, Stick11On;

    // Use this for initialization
    void Start () {

        Stick1On = false;
        Stick2On = false;
        Stick3On = false;
        Stick4On = false;
        Stick5On = false;
        Stick6On = false;
        Stick7On = false;
        Stick8On = false;
        Stick9On = false;
        Stick10On = false;
        Stick11On = false;

    }
	
	// Update is called once per frame
	void Update () {


        SpawnTab1();
        SpawnTab2();

    }

    public void SpawnTab1()
    {
        if (BridgeCrystal.SpawnTab1 == true)
        {
            Tab1.SetActive(true);
        }
    }

    public void SpawnTab2()
    {
        if (Stick1.PosNo == 4 || Stick1.PosNo == 8)
        {
            Stick1On = true;
        }
        else
        {
            Stick1On = false;
        }
        if (Stick2.PosNo == 2 || Stick2.PosNo == 6)
        {
            Stick2On = true;
        }
        else
        {
            Stick2On = false;
        }
        if (Stick3.PosNo == 2 || Stick3.PosNo == 6)
        {
            Stick3On = true;
        }
        else
        {
            Stick3On = false;
        }
        if (Stick4.PosNo == 3 || Stick4.PosNo == 7)
        {
            Stick4On = true;
        }
        else
        {
            Stick4On = false;
        }
        if (Stick5.PosNo == 2 || Stick5.PosNo == 6)
        {
            Stick5On = true;
        }
        else
        {
            Stick5On = false;
        }
        if (Stick6.PosNo == 2 || Stick6.PosNo == 6)
        {
            Stick6On = true;
        }
        else
        {
            Stick6On = false;
        }
        if (Stick7.PosNo == 4 || Stick7.PosNo == 8)
        {
            Stick7On = true;
        }
        else
        {
            Stick7On = false;
        }
        if (Stick8.PosNo == 1 || Stick8.PosNo == 5)
        {
            Stick8On = true;
        }
        else
        {
            Stick8On = false;
        }
        if (Stick9.PosNo == 1 || Stick9.PosNo == 5)
        {
            Stick9On = true;
        }
        else
        {
            Stick9On = false;
        }
        if (Stick10.PosNo == 4 || Stick10.PosNo == 8)
        {
            Stick10On = true;
        }
        else
        {
            Stick10On = false;
        }
        if (Stick11.PosNo == 2 || Stick11.PosNo == 6)
        {
            Stick11On = true;
        }
        else
        {
            Stick11On = false;
        }

        if (Stick1On == true)
        {
            if (Stick2On == true)
            {
                if (Stick3On == true)
                {
                    if (Stick4On == true)
                    {
                        if (Stick5On == true)
                        {
                            if (Stick6On == true)
                            {
                                if (Stick7On == true)
                                {
                                    if (Stick8On == true)
                                    {
                                        if (Stick9On == true)
                                        {
                                            if (Stick10On == true)
                                            {
                                                if (Stick11On == true)
                                                {
                                                    Tab3.SetActive(true);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
