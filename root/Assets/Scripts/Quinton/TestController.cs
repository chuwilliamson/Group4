using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour
{

    public GameObject s;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
            s.GetComponent<TestGUI>().GuiONOFF(true);
        if (Input.GetKeyDown(KeyCode.X))
            s.GetComponent<TestGUI>().GuiONOFF(false);
        
    }
}
