using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour 
{
    private GameObject player;
    private GameObject turret;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.D))
        { 
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayerActions.instance.Slap();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            PlayerActions.instance.Shoot();
        }

        ////Turret Controls
        //Place Turrets

        //Select turret to place
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            TurretManager.instance.PlaceTurret();
        }
	}


}
