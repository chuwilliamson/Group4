using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour 
{
    public GameObject playerInv;
    public GameObject gameManager;
    
    private int scarpGoal = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (playerInv.GetComponent<ItemDatabase>().scraps >= scarpGoal)
        {
            Debug.Log("You Win");
            gameManager.GetComponent<LevelLoader>().loadLevel("Exit");
        }

        GameObject.Find("HUDManager").GetComponent<HUDManager>().ScrapHUD(playerInv.GetComponent<ItemDatabase>().scraps);

	}
}
