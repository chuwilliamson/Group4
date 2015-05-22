using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour 
{
    public List<GameObject> persistant;
    public string testNext;     // Test 
    
    void addPersistant(GameObject o)
    {
        persistant.Add(o);
    }
    void removePersistant(GameObject o)
    {
        persistant.Remove(o);
    }

    void loadLevel(string nextLevel)
    {
        currentLevel = nextLevel;
        lastLevel = Application.loadedLevelName;
        Application.LoadLevel(nextLevel);
        // Carring over persistant Objects
        DontDestroyOnLoad(gameObject);
        for (int i =0; i < persistant.Count; i++)
        {
            DontDestroyOnLoad(persistant[i]);
        }          
    }
    void loadPrevios()
    {
        loadLevel(lastLevel);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.E))
        {
            loadLevel(testNext);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
           loadPrevios();
        }
	}

    Stack<string> lvlStack = new Stack<string>();
    void OnLevelWasLoaded(int lvl)
    {
        lastLevel = lvlStack.Peek();
        currentLevel = Application.loadedLevelName;
        lvlStack.Push(currentLevel);

    }

    private string lastLevel;
    public string currentLevel;
}
