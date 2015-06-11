using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    private float damage = 10;

    void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player") ||
            other.CompareTag("Turret") ||
            other.CompareTag("Goal") )
        {
            other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
        }
    }
}
