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
    void Update()
    {
        ////Player States
        if (Input.GetKeyDown(KeyCode.W)) //Walk forwrad
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.A)) //Walk to the left
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.S)) //Walk backwards
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.D)) //Walk to the right
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) //toggles run
        {
            player.GetComponent<PlayerActions>().State(PlayerState.run);
        }

        if (Input.GetKeyDown(KeyCode.I)) //toggles idles
        {
            player.GetComponent<PlayerActions>().State(PlayerState.idle);
        }

        if (Input.GetKeyDown(KeyCode.O)) //toggles init
        {
            player.GetComponent<PlayerActions>().State(PlayerState.init);
        }



        ////Player Actions
        if (Input.GetKeyDown(KeyCode.F)) //slaps
        {
            player.GetComponent<PlayerActions>().Slap();
        }

        if (Input.GetKeyDown(KeyCode.V)) //shoots
        {
            player.GetComponent<PlayerActions>().Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Space)) //jumps
        {
            player.GetComponent<PlayerActions>().Jump();
        }


        ////Turret Controls
        //Place Turrets

        //Select turret to place
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            TurretManager.instance.PlaceTurret();
        }


        ////GameManager Controls

        if (Input.GetKeyDown(KeyCode.P))
        {
            /// Pause State Full (Update Halted)
            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            /// 
            //GameManager.instance.Transition();
        }
    }
        
}
