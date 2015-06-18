using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    public GameObject progess;
    private float m_Timer;
    public float  SpawnDelay;
    public bool canSpawn;

    int enemyCount = 0;

    int enemyCount = 0;

    void Start()
    {
<<<<<<< HEAD

        m_Timer = 0;
        SpawnDelay = 3;

=======
        m_Timer = 0;
        SpawnDelay = 3;
        canSpawn = true;
>>>>>>> Eric/master
    }

	void Update ()
    {
<<<<<<< HEAD
        m_Timer += Time.deltaTime;

        if (m_Timer >= SpawnDelay && enemyCount <= progess.GetComponent<LevelProgression>().numOfEnemies)
        {
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
            m_Timer = 0;
            enemyCount = enemyCount + 1;
        }

        if (m_Timer >= SpawnDelay)
=======
        if (m_Timer >= SpawnDelay && canSpawn)
>>>>>>> Eric/master
        {
            m_Timer = 0;
            int pos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[pos].position, transform.rotation);

            enemy.transform.localScale *= Random.Range(1f, 2f);

        }
	}
}
