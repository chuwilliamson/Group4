using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour 
{
    public List<GameObject> persistant;
    
    void addPersistant(GameObject o)
    {
        persistant.Add(o);
    }
    void removePersistant(GameObject o)
    {
        persistant.Remove(o);
    }

    void loadLevel(string nextLevel, LevelState state)
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
    void ExitGame()
    {
        Application.Quit();
    }
    Stack<string> lvlStack = new Stack<string>();
    void OnLevelWasLoaded(int lvl)
    {
        lastLevel = lvlStack.Peek();
        currentLevel = Application.loadedLevelName;
        lvlStack.Push(currentLevel);

    }

    private string lastLevel;
    public  string currentLevel;
}
