using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float damage;

    void OnTriggerStay (Collider other)
    {
        var co = other.GetComponent<Stats>();

        if (co)
        {
            if (GetComponentInParent<Stats>().shootable) // Shootable = alive
            {
                if (!co.isEnemy)                            // Dont attack other enemies
                {
                    other.gameObject.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
                }
            }
        }
    }
}
