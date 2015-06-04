using UnityEngine;
using System.Collections;

public class EnemyStats : Stats
{
    public GameObject Drop;
    public bool m_PowerLevel;
    public int m_pLvl;

    void Start()
    {
        m_Level = 1;

        m_Acc = 1;
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;

        m_PowerLevel = false;
    }

    void TakeDamage(int amount, Vector3 hitPoint)
    {
        m_Health -= amount;
    }

    void Update()
    {
        if (m_PowerLevel)
            PowerLevel(m_pLvl);

        if (m_Health <= 0)
            Die();

        if (Input.GetKey(KeyCode.Return))
            m_Health -= 5;
    }

    void PowerLevel(int lvl)
    {
        while (m_Level < lvl)
            LevelUp();

        m_PowerLevel = false;
    }

    void Die()
    {
        int i = Random.Range(5, 11);
        Vector3 DropPos = gameObject.transform.position;

        for (int j = 0; j < i; j++)
        {
            DropPos.x += Random.Range(-.5f, .51f);
            DropPos.z += Random.Range(-.5f, .51f);
            DropPos.y = 0.5f;
            GameObject d = Instantiate(Drop, DropPos, transform.rotation) as GameObject;
            d.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }

        Destroy(gameObject);
    }
}
