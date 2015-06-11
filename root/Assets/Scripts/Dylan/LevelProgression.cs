using UnityEngine;
using System.Collections;

public class LevelProgression : MonoBehaviour 
{
    public GameObject gameManager;

    private int numOfWaves = 5;
    private int curWave = 1;

    private int goalKillCount = 10;
    private int numOfKills = 0;

    private void progress()
    {
        curWave = curWave + 1;
        goalKillCount = goalKillCount * curWave;
    }

    void Update()
    {
        if(numOfKills >= goalKillCount && curWave != numOfWaves)
        {
            progress();
        }
        if(numOfKills >= goalKillCount && curWave == numOfWaves)
        {
            gameManager.GetComponent<LevelLoader>().loadLevel("Exit");
        }
    }
	
}
