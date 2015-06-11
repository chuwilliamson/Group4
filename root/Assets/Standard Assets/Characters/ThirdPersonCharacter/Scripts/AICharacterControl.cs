using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public NavMeshAgent agent { get; private set; } // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target; // target to aim for
        public Transform goal;

        // Use this for initialization
        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

            goal = GameObject.FindGameObjectWithTag("Goal").transform;
            target = goal;

	        agent.updateRotation = false;
	        agent.updatePosition = true;
        }


        // Update is called once per frame
        private void Update()
        {
            if (target != goal)
            {
                agent.SetDestination(target.position);
                
                // use the values to move the character
                character.Move(agent.desiredVelocity, false, false);
            }
            else
            {
                agent.SetDestination(goal.position);

                // use the values to move the character to the goal
                character.Move(agent.desiredVelocity, false, false);
            }

        }

        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
                target = other.transform;

            else if (other.gameObject.tag == "Turret")
                target = other.transform;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject == target.gameObject)
                target = goal;
        }

        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
