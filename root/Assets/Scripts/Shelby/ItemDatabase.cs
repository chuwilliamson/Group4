using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : Database
{
    public int scraps, scraps_special;
    private int goalScraps = 100;

    void Update()
    {
        if(scraps >= goalScraps)
        {
            
        }
    }
}
