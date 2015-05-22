using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{

    
    public override void OnInspectorGUI()
    {
        
        DrawDefaultInspector();
        GameManager gm = (GameManager)target;

        if (gm.Levels.Count == 0)
        {
            if (GUILayout.Button("No levels yet... Click to Populate"))
            {
                GameObject test = new GameObject();
                test.name = "test";
                Instantiate(test);
                gm.PopulateArray(test.name);
            }
        }  
        else
        {
            if (GUILayout.Button("Populate Levels"))
                gm.PopulateArray();
        }
    }
}
