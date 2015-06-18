using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
<<<<<<< HEAD
    private float damage = 10;

=======
<<<<<<< HEAD

    private float damage = 100;

    private float damage = 10;


=======
    private float damage = 10;

>>>>>>> Eric/master
>>>>>>> 39207fe6139fa5620cfb47c8e02cd1a3e96b2cf7
    void OnTriggerStay (Collider other)
    {
        if (other.GetComponent<Stats>() && !other.GetComponent<Stats>().isEnemy)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD

            other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);

>>>>>>> 39207fe6139fa5620cfb47c8e02cd1a3e96b2cf7
            if (other.GetComponent<Stats>().isPlayer || other.GetComponent<Stats>().isTurret)
            {
                other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
            }
<<<<<<< HEAD
=======

=======
            if (other.GetComponent<Stats>().isPlayer || other.GetComponent<Stats>().isTurret || other.GetComponent<Stats>().isGoal)
            {
                other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
            }
>>>>>>> Eric/master
>>>>>>> 39207fe6139fa5620cfb47c8e02cd1a3e96b2cf7
        }
    }
}
