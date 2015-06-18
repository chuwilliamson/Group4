﻿using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject a;

    public GameObject progess;
    private float m_Timer;
    public float  SpawnDelay;

    public bool canSpawn;

    int enemyCount = 0;

    void Start()
    {
        m_Timer = 0;
        SpawnDelay = 3;
        canSpawn = true;
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer >= SpawnDelay && canSpawn)
        {
            Instantiate(a, gameObject.transform.position, gameObject.transform.rotation);
            m_Timer = 0;
            enemyCount = enemyCount + 1;
        }
	}
}
