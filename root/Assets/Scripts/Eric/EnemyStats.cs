using UnityEngine;
using System.Collections;

public class EnemyStats : Stats
{
    public GameObject Drop;
    public GameObject sDrop;
    public GameObject Item;
    public bool m_PowerLevel;
    public int m_pLvl;

    float dieDelay, dieTimer;

    void Start()
    {
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;

        dieTimer = 0;
        dieDelay = 5;

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

        if (m_Health < 0)
        {
            m_Health = 1;
            Die();
        }

        if(gameObject.CompareTag("Dead"))
        {
            if (transform.eulerAngles.x < 80)
            {
                transform.Rotate(Vector3.right * Time.deltaTime * 50);
            }
            else
            {
                dieTimer += Time.deltaTime;
            }

            if (dieTimer >= dieDelay)
            {
                Destroy(gameObject);
            }
        }
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
            DropPos.y = gameObject.transform.position.y;


            GameObject _specialDrop, _item, _regDrop;

            //rolled 7 spawn an enemy
            if (j == 7)
            {
               _specialDrop = Instantiate(sDrop, DropPos, transform.rotation) as GameObject;
               _specialDrop.name = "enemy";
            }
            //rolled a 10 spawn an item
            else if (j == 10)
            {
                _item = Instantiate(Item, DropPos, transform.rotation) as GameObject;
                _item.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
                //_item.name = _item.GetComponent<EquipmentStats>().name;
                

            }

            else
            {
                _regDrop = Instantiate(Drop, DropPos, transform.rotation) as GameObject;
                _regDrop.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
                _regDrop.name = "defaultScrak" + j.ToString();
            }
        }


        GetComponent<Animator>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>().enabled = false;
        tag = "Dead";
        

        //Destroy(gameObject);
    }
}
