using UnityEngine;
using System.Collections;

public class EnemyStates : MonoBehaviour {

    NavMeshAgent enemy;
    public GameObject player;

    public enum States { Idle, Patroll, Chase };
    public States enemyStates = States.Idle;
    public Transform[] points;
    public float delay;

    public float timer;
    private int destPoint = 0;
   

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
        timer += Time.deltaTime;
	    switch(enemyStates)
        {
            case States.Idle:

                enemy.velocity = new Vector3(0, 0, 0);

                if (Vector3.Distance(enemy.transform.position, player.transform.position) <= enemy.radius)
                { enemyStates = States.Chase; }

                if(timer > delay)
                { enemyStates = States.Patroll; }
                break;

            case States.Patroll:

                if(enemy.remainingDistance < 1)
                { GoToNextPoint(); }

                if(Vector3.Distance(enemy.transform.position, player.transform.position) <= enemy.radius)
                { enemyStates = States.Chase; }
                break;

            case States.Chase:
               
                enemy.destination = player.transform.position;

                if (Vector3.Distance(enemy.transform.position, player.transform.position) > 6)
                { timer = 0; enemyStates = States.Idle; }
                break;
        }

	}
}
