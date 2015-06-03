using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
public class GameManager : Singleton<GameManager>
{
    //[horizontalLine]
    [HideInInspector]
    public List<string> Levels = new List<string>();

    public AnimationCurve curve;
    // Game State possible  : <Enum>
    public enum StateManager 
    { 
        INIT,
        MAINMENU,
        RUNNING,
        EXIT
    };
    // Different Level      : <Enum>
    public enum Level
    {
        MainMenu,
        Level1,
        Level2,
        Level3,
        Conclusion,
    }
    // Pause State rate     : <Enum>
    public enum PauseState
    {
        Full,       // Update Halted
        Half,       // Update at half speed
        None,       // Update rate not effected
    }

    private bool transitionPossible;
    private StateManager c_GameState;
    private Level        c_Level;
    private PauseState   c_PauseState;
    

    protected override void Awake()
    {
        transitionPossible = true;
        c_GameState = StateManager.INIT;
        base.Awake();           
    }

    public void PopulateArray()
    {
        print("print that array");
    }

    [ContextMenu("do the thing i said to do")]
    public void doIt()
    {
        GameObject blah = new GameObject();
        blah.name = "doit";
        Instantiate(blah);
        print("do it dude make a go");
    }

    public void PopulateArray(string go)
    {
        Levels.Add(go);
        print(curve.Evaluate(0.5f));
    }

    /// usage: GameManager.instance.Transition("Combat")
    public void Transition (Level lev)
    {
        switch (lev)
        {
            case Level.MainMenu:
                if (CheckTransition(StateManager.MAINMENU))
                {
                    Application.LoadLevel(Levels[(int)Level.MainMenu]);
                    c_GameState = StateManager.MAINMENU;
                }
                break;
            case Level.Level1:
                if (CheckTransition(StateManager.INIT))
                {
                    Application.LoadLevel(Levels[(int)Level.Level1]);
                    c_GameState = StateManager.INIT;
                }
                break;
            case Level.Level2:
                if (CheckTransition(StateManager.INIT))
                {
                    Application.LoadLevel(Levels[(int)Level.Level2]);
                    c_GameState = StateManager.INIT;
                }
                break;
            case Level.Level3:
                if (CheckTransition(StateManager.INIT))
                {
                    Application.LoadLevel(Levels[(int)Level.MainMenu]);
                    c_GameState = StateManager.INIT;
                }
                break;
            case Level.Conclusion:
                if (CheckTransition(StateManager.EXIT))
                    Application.LoadLevel(Levels[(int)Level.Conclusion]);
                break;
            default: break;
        } 
        
        print("hit");   // test
        print(Application.loadedLevelName);
    }

    private bool CheckTransition(StateManager stateB)
    {
        if (c_GameState == stateB)
        {
            /// Not valid; Transistion to current state
            print("Already in this state. Check returned: False");
            return false;
        }

        else
        {
            switch (c_GameState)
            {
                // init to mainmenu check
                case StateManager.INIT:
                    if (stateB == StateManager.MAINMENU)
                        return true;
                    break;
                // mainmenu to running check
                case StateManager.MAINMENU:
                    if (stateB == StateManager.RUNNING)
                        return true;
                    break;
                // running back to mainmenu 
                case StateManager.RUNNING:
                    if (stateB == StateManager.MAINMENU)
                        return true;
                    if (stateB == StateManager.EXIT)
                        return true;
                    break;

                default:
                    break;
            }

            return false;
        }
    }
    

	// Use this for initialization
	void Start () 
    {
        c_GameState  = StateManager.MAINMENU;
        c_PauseState = PauseState.None;
	}
	
	// Update is called once per frame
	void Update () 
    {

        

	}

    public void Pause(PauseState state)
    {
        string debugtext = "Blank";
        switch(state)
        {
            case PauseState.None:
                { Time.timeScale = 1; debugtext = "Full Update"; }
                break;
            case PauseState.Half:
                { Time.timeScale = 0.5f; debugtext = "Half Update"; }
                break;
            case PauseState.Full:
                { Time.timeScale = 0; debugtext = "Update Halfed"; }
                break;
            default: break;
        }
        // Debug
        print("Pause function hit. State triggered: " + debugtext);
    }

    
}
