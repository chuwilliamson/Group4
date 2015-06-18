using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    public GameObject progess;
    private float m_Timer;
    public float  SpawnDelay;

    int enemyCount = 0;

    void Start()
    {
<<<<<<< HEAD
        m_Timer = 0;
        SpawnDelay = 3;
=======
>>>>>>> Eric/master
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;
<<<<<<< HEAD
        if (m_Timer >= SpawnDelay && enemyCount <= progess.GetComponent<LevelProgression>().numOfEnemies)
        {
            Instantiate(a, gameObject.transform.position, gameObject.transform.rotation);
            m_Timer = 0;
            enemyCount = enemyCount + 1;
=======

        if (m_Timer >= SpawnDelay)
        {
            m_Timer = 0;
            int pos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[pos].position, transform.rotation);
<<<<<<< HEAD
            enemy.transform.localScale *= Random.Range(1f, 2f);
>>>>>>> Eric/master
=======
>>>>>>> Eric/master
        }
	}
}
