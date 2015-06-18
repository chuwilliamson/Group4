using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    private float m_Timer;
    public float  SpawnDelay;

    void Start()
    {
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;

        if (m_Timer >= SpawnDelay)
        {
            int pos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[pos].position, transform.rotation);
            enemy.transform.localScale *= Random.Range(1f, 2f);
        }
	}
}
