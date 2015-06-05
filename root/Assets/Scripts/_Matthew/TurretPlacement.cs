﻿using UnityEngine;
using System.Collections;

public class TurretPlacement : Singleton<TurretPlacement> 
{
    public GameObject turret1, turret2, turret3, turret4;
    public GameObject dot;
    private GameObject turret;

    private int turretCount = 0;

    public bool isSelected = false; //checks to see if a turret is selected so it doesn't crash



	// Use this for initialization
	void Start () 
    {
       dot.gameObject.SetActive(false); // Make dot disppear in the start of the game
	}
	
	// Update is called once per frame
    void Update()
    {
       
    }

     public void TurretWasPlaced()
    {
        Vector3 pos = transform.position + Camera.main.transform.forward * 3;
        pos.y = 1;

        dot.gameObject.SetActive(false);
        Instantiate(turret, pos, transform.rotation);
    }

     public void TurretPlace()
    {
        
        //Sets the spawn position that the turret will be placed at
        if (Input.GetMouseButton(0))
        {
            dot.gameObject.SetActive(true);
            isSelected = false;
        }

   
 
        //if (Input.GetMouseButton(0))
        //{ }




        //ScoreManager.instance.Turret(turretCount);

    }

    public void TurretSelect(KeyCode a)
    {
        if (a == KeyCode.Alpha1) 
            // Player will press #1 - 4 keys to select which type of turret they would like to choose.  
        {
            //HUDManager.instance.TurSelectHUD("Turret 1");
            // The turret placement will be placed in front of the player by 1 unit.
            turret = turret1;
            isSelected = true;
        }

        if (a == KeyCode.Alpha2)
        {
            //HUDManager.instance.TurSelectHUD("Turret 2");
            turret = turret2;
            isSelected = true;
        }

        if (a == KeyCode.Alpha3)
        {
            //HUDManager.instance.TurSelectHUD("Turret 3");
            turret = turret3;
            isSelected = true;
        }

        if (a == KeyCode.Alpha4)
        {
            //HUDManager.instance.TurSelectHUD("Turret 4");
            turret = turret4;
            isSelected = true;
        }
    }
}
