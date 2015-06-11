using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
    GameObject[] BB; // shots inside of a shot
    public GameObject enemy;

    public float throwPower = 25f;

    private float mySpeed = 1f;
    private float maxDistance = 4f;

    private float myDist;

    private float spreadRate = 4;

    public int bDamage = 10;

    int numOfShots = 1;

    public bool isFired = false; //a bool to check if the bullet is beign fired
    public bool doDmg = false;

    public void OnTriggerEnter(Collider c)
    {
        
        if (c.tag == "Enemy")
        {
            enemy = c.gameObject;
            doDmg = true;
            Debug.Log(doDmg); 
            if (enemy != null)
            {
                enemy.GetComponent<EnemyStats>().m_Health -= bDamage;
                Destroy(gameObject);
            }

        }
    }
 
    // Update is called once per frame
    void Update()
    {

        if (isFired == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * mySpeed);
            myDist += Time.deltaTime * mySpeed;

            //moves the bullet across the screen when the turret fire

            if (myDist > maxDistance)
            {
                Destroy(gameObject);
                //checks to see if the bullet has passed the maximum distance it can travel
                //and if it dis destroy the object
            }
        }

        if (gameObject.tag == "Grenade" && isFired == true)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward * throwPower);
            transform.Translate(forward * Time.deltaTime * mySpeed);
            myDist += Time.deltaTime * mySpeed;

            //moves the bullet across the screen when the turret fire

            if (myDist > maxDistance)
            {
                Destroy(gameObject);
                //checks to see if the bullet has passed the maximum distance it can travel
                //and if it dis destroy the object
            }
        }

    }
}
