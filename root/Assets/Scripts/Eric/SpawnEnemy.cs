using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    private float m_Timer;
    public float  SpawnDelay;

<<<<<<< HEAD
    void Start()
    {
=======
    public bool canSpawn;

    int enemyCount = 0;

    void Start()
    {
        m_Timer = 0;
        SpawnDelay = 3;
        canSpawn = true;
>>>>>>> dylan/master
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;
<<<<<<< HEAD

        if (m_Timer >= SpawnDelay)
=======
        if (m_Timer >= SpawnDelay && canSpawn)
>>>>>>> dylan/master
        {
            m_Timer = 0;
            int pos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[pos].position, transform.rotation);
        }
	}
}
