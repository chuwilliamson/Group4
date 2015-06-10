using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject a;

    private float m_Timer;
    public float  SpawnDelay;

    void Start()
    {
        m_Timer = 0;
        //SpawnDelay = 3;
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer >= SpawnDelay)
        {
            Instantiate(a, gameObject.transform.position, gameObject.transform.rotation);
            m_Timer = 0;
        }
	}
}
