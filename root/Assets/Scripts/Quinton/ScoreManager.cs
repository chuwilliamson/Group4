using UnityEngine;
using System.Collections;

public class ScoreManager : Singleton<ScoreManager>
{
    [SerializeField]
    GameObject HUD;
    [SerializeField]
    GameObject GM;

    HUDManager cmp;
    GameManager gm;

    void Start()
    {
        cmp = HUD.GetComponent<HUDManager>();
        gm = GM.GetComponent<GameManager>();
    }


    


    public bool HpFloat(float curHp, float maxHp)
     {
         if (curHp > maxHp)
             curHp = maxHp;
         else if (curHp <= 0) { return false; }
         //Use GM to trigger Lose State
         
             cmp.HpHUDfloat(curHp, maxHp);
             return true;
         
        
     }

    public bool HpInt(int curHp, int maxHp)
    {
        if (curHp > maxHp)
            curHp = maxHp;
        else if (curHp <= 0) { return false; }
            //Use GM to trigger Lose State

        cmp.HpHUDint(curHp, maxHp);
        return true;
    }

     public bool ScrapFloat(float scrapCount)
     {
         if (scrapCount < 0)
         { return false; }

       cmp.ScrapHUDfloat(scrapCount);
       return true;
     }
     public bool ScrapInt(int scrapCount)
     {
         if (scrapCount < 0)
         { return false; }

         cmp.ScrapHUDfloat(scrapCount);
         return true;
     }

   
    public bool TurretFloat(float turretNumber)
    {
        if (turretNumber < 0)
            return false;

        cmp.TurHUDfloat(turretNumber);
        return true;
     }

    public bool TurretInt(int turretNumber)
    {
        if (turretNumber < 0)
            return false;

        cmp.TurHUDfloat(turretNumber);
        return true;
    }

}
