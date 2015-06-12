using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float damage;

    void OnTriggerStay (Collider other)
    {
        var co = other.GetComponent<Stats>();

        if (GetComponent<EnemyStats>().Shootable)
        {
            if (co && !co.isEnemy)
            {
               other.gameObject.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
            }
        }
    }
}
