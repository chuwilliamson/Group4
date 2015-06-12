using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    //Health related
    public float m_MaxHealth, m_Health, m_HealthRegen;

    public bool isPlayer, isEnemy, isTurret, isGoal, shootable;

    void Awake()
    {
        isPlayer = isEnemy = isTurret = isGoal = false;
        shootable = false;
    }
}
