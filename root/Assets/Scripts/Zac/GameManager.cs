using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    //// For Test only
    //public string theLevel;

    [SerializeField]
    private string mainMenu;
    [SerializeField]
    private string exitMenu;
    [SerializeField]
    private string jumpLevel;
    
    private bool transitionPossible;

    public enum StateManager 
    { 
        INIT,
        MAINMENU,
        RUNNING,
        EXIT
    };

    public enum Level
    {
        MainMenu,
        Combat,
        Conclusion,
    }
    private StateManager currentState;

    protected override void Awake()
    {
        transitionPossible = true;
        currentState = StateManager.INIT;
        base.Awake();           
    }


    /// <summary>
    /// usage: GameManager.instance.Transition("Combat")
    /// </summary>
    /// <param name="o"></param>
    public void Transition(Level lev)
    {
        
        switch(lev)
        {
            case Level.MainMenu:
                Application.LoadLevel(mainMenu);
                break;
            case Level.Combat:
                Application.LoadLevel(jumpLevel);
                break;
            case Level.Conclusion:
                Application.LoadLevel(exitMenu);
                break;

        } 
        
        print("hit");
        print(Application.loadedLevelName);


        //prevent self transition
        //if (Application.loadedLevelName /**/)
        //{
        //    transitionPossible = false;
        //    print("Already Loaded");
        //}

        //if (true)
        //{
        //    //switch (currentState)
        //    //{
        //    //    case StateManager.INIT:
        //    //        {

        //    //        } break;
        //    //    case StateManager.EXIT:
        //    //        {
        //    //            Application.LoadLevel(exitMenu);
        //    //        } break;
                 
        //    //    case StateManager.MAINMENU:
        //    //        {
        //    //            Application.LoadLevel(mainMenu);
        //    //        } break;
        //    //    case StateManager.RUNNING:
        //    //        {
        //    //            Application.LoadLevel(jumpLevel);
        //    //        } break;
        //    //}
        //}
        
    }

    


    private bool CheckTransition(StateManager stateA, StateManager stateB)
    {
        switch(stateA)
        {
                //init to mainmenu check
            case StateManager.INIT:
                if (stateB == StateManager.MAINMENU)
                    return true;
                break;
                //mainmenu to running check
            case StateManager.MAINMENU:
                if (stateB == StateManager.RUNNING)
                    return true;
                break;
                //running back to mainmenu 
                //the popback
            case StateManager.RUNNING:
                if (stateB == StateManager.MAINMENU)
                    return true;
                break;

            default:
                break;               
        }

        return false;
    }

    

    

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transition(Level.MainMenu);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Transition(Level.Combat);
        }
	}
}
