using UnityEngine;
using System.Collections;

public class GUIManager : Singleton<GUIManager>
{

    public void ChangeLvlTo(string name)
    {
        //gameManager Function for changing scene(Level)
    }
    public void ExitGame()
    {
        //gameManager Function for leaving
    }



    public void GuiONOFF(bool onoff)
    {
        //if (gameObject.activeInHierarchy != onoff)
        gameObject.SetActive(onoff);
    }



}
