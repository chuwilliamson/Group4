using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(ThirdPersonCharacter))]
    public class EnemyStates : MonoBehaviour
    {
        [SerializeField]
        NavMeshAgent enemy;
        GameObject target;

        public ThirdPersonCharacter character { get; private set; } // the character we are controlling

        public enum States { Idle, Goal, Chase };
        public States enemyStates = States.Idle;
        /// <summary>
        /// user must set this or dude wont move... this is tran prmse
        /// </summary>
        public Transform goal;
        public float delay;

        public float timer;

        void Start()
        {
            enemy = GetComponent<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
            enemy.autoBraking = false;
            goal = GameObject.FindGameObjectWithTag("Goal").transform;
            target = gameObject;

        }

        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
                target = other.gameObject;

            else if (other.gameObject.tag == "Turret")
                target = other.gameObject;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject == target)
                target = gameObject;
        }

        void Update()
        {
            timer += Time.deltaTime;
            switch (enemyStates)
            {
                case States.Idle:

                    enemy.velocity = new Vector3(0, 0, 0);

                    if (target != gameObject)
                    { enemyStates = States.Chase; }

                    if (timer > delay)
                    { enemyStates = States.Goal; }
                    break;

                case States.Goal:

                    enemy.SetDestination(goal.position);

                    if (target != gameObject)
                    { enemyStates = States.Chase; }

                    if (Vector3.Distance(enemy.transform.position, enemy.destination) <= enemy.radius)
                        enemy.Stop();
                    break;

                case States.Chase:
                    enemy.SetDestination(target.transform.position);
                    character.Move(enemy.desiredVelocity, false, false);//enemy.destination = target.transform.position;

                    if (target == gameObject)
                    { timer = 0; enemyStates = States.Idle; }
                    break;

            }

        }

    }
}
