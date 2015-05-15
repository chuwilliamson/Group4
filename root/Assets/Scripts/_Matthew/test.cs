using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{

    public enum level
    {
        menu,
        combat,
        exit,
    }
    bool datlvl = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (datlvl)
            {
                gotolvl("mainmenu");
                datlvl = !datlvl;
            }
            else
            {
                gotolvl("combat");
                datlvl = !datlvl;
            }

        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            gotolvl("wombocombo");
        }

    }

    public level thelevelIwantToGoToReallyBad;

    public void gotolvl(string name)
    {
        if (name.Contains("menu"))
            thelevelIwantToGoToReallyBad = level.menu;
        else if (name.Contains("combat"))
            thelevelIwantToGoToReallyBad = level.combat;
        else
            Debug.LogError("that lvl isn't falco");


    }

    bool s1, s2, s3, s4;
}
