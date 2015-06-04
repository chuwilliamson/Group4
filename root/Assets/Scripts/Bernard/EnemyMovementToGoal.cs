using UnityEngine;
using System.Collections;

public class EnemyMovementToGoal : MonoBehaviour 
{
    Transform goal;

    GoalHealth goalHealth;

    bool GoalInRange;

    NavMeshAgent nav;

	void Awake () 
    {
        goal = GameObject.FindGameObjectWithTag("Target").transform;
        goalHealth = goal.GetComponent<GoalHealth>();
        nav = GetComponent<NavMeshAgent>();
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject==goal)
        {
            GoalInRange = true;
        }
    }

	void Update () 
    {
	    if(goalHealth.currentHealth>0)
        {
            nav.SetDestination(goal.position);
        }

        else
        {
            nav.enabled = false;
        }
	}
}
