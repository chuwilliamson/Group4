using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject a;

    private float m_Timer, m_Delay;

    void Start()
    {
        m_Timer = 0;
        m_Delay = 3;
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer >= m_Delay)
        {
            Instantiate(a, gameObject.transform.position, gameObject.transform.rotation);
            m_Timer = 0;
        }
	}
}
