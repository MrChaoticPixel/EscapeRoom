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
        SpawnTab3();
        SpawnTab4();
        SpawnTab5();
        SpawnTab6();
    }

    public void SpawnTab1()
    {
        if (BridgeCrystal.SpawnTab1 == true)
        {
            Tab1.SetActive(true);
        }
    }

    public void SpawnTab3()
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

if (Stick1On == true && Stick2On == true && Stick3On == true && Stick4On == true && Stick5On == true && Stick6On == true && Stick7On == true && Stick8On == true && Stick9On == true && Stick10On == true && Stick11On == true)
        {
            Tab3.SetActive(true);
        }

    }

    public void SpawnTab4()
    {
        if (AnubisTwo.Reunited == true)
        {
            Tab4.SetActive(true);
        }
    }
    public void SpawnTab5()
    {
        if (TorchHolders.HolActive1 == true && TorchHolders.HolActive2 == true && TorchHolders.HolActive3 == true && TorchHolders.HolActive4 == true && TorchHolders.HolActive5 == true && TorchHolders.HolActive6 == true)
        {
            Tab5.SetActive(true);
        }
    }
    public void SpawnTab6()
    {
        if (Pillars.P1Active == true && Pillars.P2Active == true && Pillars.P3Active == true && Pillars.P4Active == true && Pillars.P5Active == true && Pillars.P6Active == true)
        {
            Tab6.SetActive(true);
        }
    }
}
