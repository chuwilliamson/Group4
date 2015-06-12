using UnityEngine;
using System.Collections;

public class TurretStats : Stats
{
    public float rotationSpeed = 5.0f;
    public float reloadSpeed = 5.0f;
    public float rateOfFire = .25f;

    public int maxAmmo = 100;
    public int currentAmmo = 100;
    public int damage = 5;

    // Use this for initialization
    void Start()
    {
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
