using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player") ||
            other.CompareTag("Turret") ||
            other.CompareTag("Goal") )
        {
            other.GetComponent<Stats>().m_Health -= 10 * Time.deltaTime;
        }
    }
}
