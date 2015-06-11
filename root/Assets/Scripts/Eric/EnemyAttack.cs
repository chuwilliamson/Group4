using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    private float damage = 100;

    void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player") ||
            other.CompareTag("Turret") ||
            other.CompareTag("Goal") )
        {
            other.GetComponent<Stats>().m_Health -= (int)(damage * Time.deltaTime);
        }
    }
}
