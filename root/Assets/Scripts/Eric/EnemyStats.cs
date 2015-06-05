using UnityEngine;
using System.Collections;

public class EnemyStats : Stats
{
    public GameObject Drop;
    public GameObject sDrop;
    public bool m_PowerLevel;
    public int m_pLvl;
    
    void Start()
    {
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
        //if (m_PowerLevel)
        //    PowerLevel(m_pLvl);
        if (m_Health <= 0)
            Die();
    }

    //void PowerLevel(int lvl)
    //{
    //    while (m_Level < lvl)
    //        LevelUp();

    //    m_PowerLevel = false;
    //}

    void Die()
    {
        int i = Random.Range(5, 11);
        Vector3 DropPos = gameObject.transform.position;

        for (int j = 1; j <= i; j++)
        {
            DropPos.x += Random.Range(-.5f, .51f);
            DropPos.z += Random.Range(-.5f, .51f);
            DropPos.y = 0.5f;

            GameObject d;

            if (j == 7)
               d = Instantiate(sDrop, DropPos, transform.rotation) as GameObject;

            else
                d = Instantiate(Drop, DropPos, transform.rotation) as GameObject;

            d.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }

        Destroy(gameObject);
    }
}
