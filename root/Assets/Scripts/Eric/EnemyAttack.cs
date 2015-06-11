using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float damage;

    void OnTriggerStay (Collider other)
    {
        var co = other.gameObject.GetComponent<Stats>();

        if (!GetComponent<EnemyStats>().dead)
        {
            if (co)
            {
                if (co.isPlayer || co.isTurret || co.isGoal)
                {
                    other.gameObject.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
                }
            }
        }
    }
}
