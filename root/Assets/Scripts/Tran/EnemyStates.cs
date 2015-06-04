using UnityEngine;
using System.Collections;

public class EnemyStates : MonoBehaviour {

    NavMeshAgent enemy;
    private GameObject target;

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
        target = gameObject;
       
	}
	
    void GoToNextPoint()
    {
        // return if no point have been set
        if (points.Length == 0) { return; }
        enemy.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
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

	void Update () 
    {
        timer += Time.deltaTime;
	    switch(enemyStates)
        {
            case States.Idle:

                enemy.velocity = new Vector3(0, 0, 0);

                if (target != gameObject)//(Vector3.Distance(enemy.transform.position, target.transform.position) <= enemy.radius)
                { enemyStates = States.Chase; }

                if(timer > delay)
                { enemyStates = States.Patroll; }
                break;

            case States.Patroll:

                if(enemy.remainingDistance < .5f)
                { GoToNextPoint(); }

                if (target != gameObject) //(Vector3.Distance(enemy.transform.position, target.transform.position) <= enemy.radius)
                { enemyStates = States.Chase; }
                break;

            case States.Chase:
               
                enemy.destination = target.transform.position;

                if (target == gameObject) //(Vector3.Distance(enemy.transform.position, target.transform.position) > 6)
                { timer = 0; enemyStates = States.Idle; }
                break;

        }

	}
  
}
