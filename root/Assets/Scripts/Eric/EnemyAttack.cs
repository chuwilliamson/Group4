using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
<<<<<<< HEAD
    private float damage = 100;
=======
    private float damage = 10;
>>>>>>> Quinton/master

    void OnTriggerStay (Collider other)
    {
        if (other.GetComponent<Stats>() && !other.GetComponent<Stats>().isEnemy)
        {
<<<<<<< HEAD
            other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
=======
            if (other.GetComponent<Stats>().isPlayer || other.GetComponent<Stats>().isTurret)
            {
                other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
            }
>>>>>>> Quinton/master
        }
    }
}
