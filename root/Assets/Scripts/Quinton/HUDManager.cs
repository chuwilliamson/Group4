using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
///  The Numbers displeyed in the HUD will be set by the ScoreManager
/// 
///  "ScoreManager.cs Needed"
/// 
/// </summary>
public class HUDManager : Singleton<HUDManager>
{
    [SerializeField] GameObject hp;
    [SerializeField] GameObject turrent;
    [SerializeField] GameObject scrap;
    [SerializeField] GameObject promp;

    void Awake()
    {
        GUIManager.instance.SetState(promp, false);
    }
   

    /// <summary>
    /// Used by the Score Manager Do not call.
    /// </summary>
    /// // // // // // // // // // // // // // // // // // // // // // // // // // // //
     public void HpHUDfloat(float curHp, float maxHp)
    {
        hp.GetComponent<Text>().text = curHp.ToString() + '/' + maxHp.ToString();
    }
     public void HpHUDint(int curHp, int maxHp)
    {
        hp.GetComponent<Text>().text = curHp.ToString() + '/' + maxHp.ToString();
    }
     public  void ScrapHUDfloat(float scraps)
    {
        scrap.GetComponent<Text>().text = scraps.ToString();
    }
     public void ScrapHUDint(int scraps)
    {
        scrap.GetComponent<Text>().text = scraps.ToString();
    }
     public void TurHUDfloat(float tur)
    {
        turrent.GetComponent<Text>().text = tur.ToString();
    }
     public void TurHUDint(int tur)
    {
        turrent.GetComponent<Text>().text = tur.ToString();
    }
    /// // // // // // // // // // // // // // // // // // // // // // // // // // // //

     public void PrompDis(string strng)
     {
         //if its already active turn it off
         if (promp.activeSelf)
             promp.GetComponent<Text>().text = strng;
         //otherwise activate it
         else
         {
             GUIManager.instance.SetState(promp, true);
             promp.GetComponent<Text>().text = strng;
         }
        // Debug.Log("Settings");

     }


    public void PrompClear()
     {

        // promp.SetActive(false);

     }
  
   

}
