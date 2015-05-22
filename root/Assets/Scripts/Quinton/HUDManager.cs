using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class HUDManager : Singleton<HUDManager>
{
    [SerializeField] GameObject hp;
    [SerializeField] GameObject turrent;
    [SerializeField] GameObject scrap;
    [SerializeField] GameObject promp;

    

    List<GameObject> Log = new List<GameObject>();
    [SerializeField] GameObject LogText;
    private int nexTile = 0;
    private int maxLogSize = 5;

    void Awake()
    {
        GUIManager.instance.SetState(promp, false);

        Log.Add(LogText);
        nexTile++;

    }
   

    /// <summary>
    /// Changes the Text for hp,turrent,scrap 
    /// </summary>
    /// // // // // // // // // // // // // // // // // // // // // // // // // // // //
     public void HpHUD(float curHp, float maxHp)
    {
        string curString = curHp.ToString();
        string maxString = maxHp.ToString();

         if(curHp >= 10000)
         {
             curHp /= 1000;
             
             curString = curHp.ToString("#.#") + 'K';
         }
         if(maxHp >= 10000)
         {
             maxHp /= 1000;
             maxString = curHp.ToString("#.#") + 'K';
         }


        hp.GetComponent<Text>().text = curString + '/' + maxString;
    }
     public void HpHUD(int curHp, int maxHp)
     {
         string curString = curHp.ToString();
         string maxString = maxHp.ToString();

         if (curHp >= 10000)
         {
             
             curHp /= 1000;
             curString = curHp.ToString("#.#") + 'K';
         }
         if (maxHp >= 10000)
         {
             maxHp /= 1000;
             curString = curHp.ToString("#.#") + 'K';
         }


         hp.GetComponent<Text>().text = curString + '/' + maxString;
     }
     public void ScrapHUD(float scraps)
    {

        string scrapsString = scraps.ToString("#.#");

        if (scraps >= 10000)
        {
            scraps /= 1000;
            scrapsString = scraps.ToString("#.#") + 'K';
        }
        scrap.GetComponent<Text>().text = scrapsString;
    }
     public void ScrapHUD(int scraps)
     {

         string scrapsString = scraps.ToString();

         if (scraps >= 10000)
         {
             scraps /= 1000;
             scrapsString = scraps.ToString() + 'K';
         }
         scrap.GetComponent<Text>().text = scrapsString.ToString();
     }
     public void TurHUD(float tur)
    {
        turrent.GetComponent<Text>().text = tur.ToString();
    }
     public void TurHUD(int tur)
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
  
    public void SetLogSize(int size)
     {
         maxLogSize = size;
     }
    /// <summary>
    /// 
    /// Creates a new Tile based on the position of the last tile created and moves all the tiles up.
    /// 
    /// if the tile number gets to the same number as maxLogSize the next tile is not created but instead the first tile in the array moved to the start location.
    /// 
    /// 
    /// </summary>
    /// <param name="strng"></param>
    public void LogUp(string strng)
     {
         int prev = 0;
         if (nexTile < maxLogSize) { prev = nexTile;  nexTile = 0; }

        if(nexTile <= maxLogSize && Log.Count < nexTile)
        {
            Vector3 vec3 = Log[nexTile-1].GetComponent<RectTransform>().localPosition;
            vec3.y += Log[nexTile-1].GetComponent<RectTransform>().sizeDelta.y;
            GameObject a = (GameObject)Instantiate(LogText, vec3, Log[nexTile-1].GetComponent<RectTransform>().localRotation);
            Log.Add(a);
            Log[nexTile].GetComponent<Text>().text = strng;

            nexTile++;
        }
        else if(nexTile <= maxLogSize && Log[nexTile].activeSelf == true)
        {
            Vector3 vec3 = Log[prev].GetComponent<RectTransform>().localPosition;
            vec3.y += Log[prev].GetComponent<RectTransform>().sizeDelta.y;
          
            Log[nexTile].GetComponent<Text>().text = strng;
        }

        for (int i = 0; i <= Log.Count - 1; i++)
        {
            Vector3 vec3 = Log[i].GetComponent<RectTransform>().localPosition;
            vec3.y += Log[nexTile - 1].GetComponent<RectTransform>().sizeDelta.y;
            Log[i].GetComponent<RectTransform>().localPosition = vec3;
        }


     }
    /*
     
     * Log:
     * 
     * Array of logs
     * 
     
     */
   

}
