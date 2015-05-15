using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    [ContextMenu("Space")]
    void Space()
    {
        foreach (GameObject go in list)
        {
            go.transform.position = new Vector3(go.transform.position.x + 5, go.transform.position.y + 5, go.transform.position.z + 5);
        }
    }
}
