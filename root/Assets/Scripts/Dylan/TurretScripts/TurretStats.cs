using UnityEngine;
using System.Collections;

public class TurretStats : Stats
{
    public enum e_TurretType
    {
        e_MachineGun,
        e_AntiAir,
        e_ShotGun,
    }

    public float rotationSpeed = 5.0f;

    public int damage = 5;

    public GameObject bullet;
    public GameObject turretView;

    public GameObject target;
    public Transform[] barrelPos;
    public Transform[] turretTop;

    public Quaternion rotationToGoal;
    public int t_cycle;
    public float t_RateOfFire;
    public float t_ReloadTime;

    public e_TurretType type;

    void OnTriggerStay(Collider c)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        if (c.GetComponentInParent<Stats>().isShootable == true)
        {
            target = c.gameObject;
            Debug.Log("Hi Mr.Panda");
        }
        Debug.Log("Let me love you");
=======
        if(c.GetComponentInParent<Stats>())
        if (c.GetComponentInParent<Stats>().isShootable == true)
        {
            target = c.gameObject;
        }
>>>>>>> Quinton/master
=======
        if (c.GetComponent<Stats>())
            if (c.GetComponentInParent<Stats>().isShootable == true)
            {
                target = c.gameObject;
                Debug.Log("Hi Mr.Panda");
            }
        Debug.Log("Let me love you");
>>>>>>> Eric/master
    }

    void OnTriggerExit(Collider c)
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
        if (c.GetComponentInParent<Stats>())
>>>>>>> Quinton/master
        if (c.GetComponentInParent<Stats>().isShootable == true)
            target = null;
=======
        if (c.GetComponent<Stats>())
            if (c.GetComponentInParent<Stats>().isShootable == true)
                target = null;
>>>>>>> Eric/master
    }

    // Use this for initialization
    void Start()
    {
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;
        if (type == e_TurretType.e_MachineGun)
        {
            m_maxAmmo = 30;
            t_RateOfFire = Time.deltaTime * .25f;
            t_ReloadTime = Time.deltaTime * 5.0f;
        }

        if (type == e_TurretType.e_AntiAir)
        {
            m_maxAmmo = 100;
            t_RateOfFire = Time.deltaTime * .10f;
            t_ReloadTime = Time.deltaTime * 7.0f;
        }


        if (type == e_TurretType.e_ShotGun)
        {
            m_maxAmmo = 5;
            t_RateOfFire = Time.deltaTime *  .1f;
            t_ReloadTime = Time.deltaTime * 8.0f;
        }
        m_Ammo = m_maxAmmo;

        isTurret = true;
        target = null;
    }

    void Update()
    {
        if(m_Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
