using UnityEngine;
using System.Collections;

public class FixExit : MonoBehaviour {

    public AudioClip GameOver;

	// Use this for initialization
	void Start () {
        HUDManager.instance.SetState("start",  false);
        HUDManager.instance.SetState("panel",  false);
        HUDManager.instance.SetState("menu",   false);
        HUDManager.instance.SetState("finish", true);
        AudioManager.instance.PlayAudio(GameOver);

        print("fix exit");
        //GameManager.instance.Pause(GameManager.PauseState.Full);

	}
	
}
