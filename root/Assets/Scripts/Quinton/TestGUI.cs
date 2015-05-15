using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestGUI : Singleton<TestGUI> 
{

    /*
     Make new "UI"
     
     *  
     *
     * 
     * 
          
     */

    

     
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
    





    //public void HpGUI(float curent, float max)
    //{
        
    //} 
    //public void GrenadeGUI(float curent, float max)
    //{

    //}
    
    //public void ScrapsGUI(float curent)
    //{

    //}
    //public void TurretGUI(float curent)
    //{

    //}
   

    

   

   

  
 
}
