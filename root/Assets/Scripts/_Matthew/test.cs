using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    void Update()
    {
        HUDManager.instance.SetInfoLeft(Time.deltaTime.ToString() + "\n" + "dudes are dudes");
    }
}
