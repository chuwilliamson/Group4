using UnityEngine;
using System.Collections;

public class EnemyStates : MonoBehaviour {

    
    public enum States { Idle, Patroll, Chase };
    public States enemyStates = States.Idle;
    public Transform[] points;

    private int destPoint = 0;

    NavMeshAgent enemy;
    public GameObject player;

	void Start () 
    {
        enemy = GetComponent<NavMeshAgent>();
        enemy.autoBraking = false;
	}
	
    void GoToNextPoint()
    {
        // return if no point have been set
        if (points.Length == 0) { return; }
        enemy.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;

    }

	void Update () 
    {

	    switch(enemyStates)
        {
            case States.Idle:
                enemy.velocity = new Vector3(0, 0, 0);
                break;

            case States.Patroll:
                if(enemy.remainingDistance < 0.5f)
                { GoToNextPoint(); }
                break;

            case States.Chase:
               
                enemy.destination = player.transform.position;
                break;
        }

	}
}
