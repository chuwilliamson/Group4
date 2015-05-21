﻿using UnityEngine;
using System.Collections;

public class TurretPlacement : MonoBehaviour 
{
    public GameObject turret1, turret2, turret3, turret4;
    public GameObject dot;
    private GameObject turret;

    public bool isSelected = false; //checks to see if a turret is selected



	// Use this for initialization
	void Start () 
    {
        dot.gameObject.SetActive(false);
	}


	
	 //Update is called once per frame
    void Update()
    {
        TurretSelect();
        TurretPlace();
      //  calls in the functions for selecting a turret and placing the turrets
    }

    void TurretPlace()
    {
        Vector3 pos = transform.position + Camera.main.transform.forward * 3;
        pos.y = 1;
        //Sets the spawn position that the turret will be placed at

        if (Input.GetMouseButtonDown(0))
        {
            dot.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0) && isSelected == true)
        {
            dot.gameObject.SetActive(false);
            Instantiate(turret, pos, transform.rotation);
            isSelected = false;
        }

        if(Input.GetMouseButtonUp(0))
        {
            dot.gameObject.SetActive(false);
        }
    }

    
    public void TurretSelect(int choice = 0)
    {
        if (Input.GetKeyDown("1"))
        // Player will press #1 - 4 keys to select which type of turret they would like to choose.  
        {
            print("1 Turret Selected");
            // The turret placement will be placed in front of the player by 1 unit.
            turret = turret1;
            isSelected = true;
        }

        if (Input.GetKeyDown("2"))
        {
            print("2 Turret Selected");
            turret = turret2;
            isSelected = true;
        }

        if (Input.GetKeyDown("3"))
        {
            print("3 Turret Selected");
            turret = turret3;
            isSelected = true;
        }

        if (Input.GetKeyDown("4"))
        {
            print("4 Turret Selected");
            turret = turret4;
            isSelected = true;
        }
        //switch(choice)
        //{
        //    case 1:  
        //        {
        //            print("1 Turret Selected");
        //            //The turret placement will be placed in front of the player by 1 unit.
        //            turret = turret1;
        //            isSelected = true; break;
        //        }
        //}
    }
}
