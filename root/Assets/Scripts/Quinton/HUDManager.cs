using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDManager : Singleton<HUDManager>
{
    [SerializeField]
     GameObject hp;
    [SerializeField]
     GameObject turrent;
    [SerializeField]
     GameObject scrap;
    

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

}
