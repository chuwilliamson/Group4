
using UnityEngine;
using System.Collections;

public class PlayerStats : Stats
{
    public float m_reginDelay;
    private float m_reginTimer, m_preaviousHealth;

    void Awake() { DontDestroyOnLoad(gameObject); }

	void Start()
    {
        m_MaxHealth = 100;
        m_HealthRegen = 5;
        m_Health = m_MaxHealth;
    }

    void Update()
    {
        //Will only regin health if play has not recived damage for as long as m_reginDelay
        //if (m_preaviousHealth == m_Health)
        //    m_reginTimer += Time.deltaTime;
        //else
        //    m_reginTimer = 0;

        //Will only regin health if m_Health is lower than m_MaxHealth
        //if(m_reginTimer >= m_reginDelay && m_Health <= m_MaxHealth
        //    && gameObject.GetComponent<PlayerStates>().cState == PlayerStates.eStates.Idle)
        //    m_Health += m_HealthRegen * Time.deltaTime;

        HUDManager.instance.HpHUD(m_Health, m_MaxHealth);

        m_preaviousHealth = m_Health;
    }

    //Increses player's stats when called
    //override protected void LevelUp()
    //{
    //    m_Exp = 0;
    //    m_Level += 1;

    //    switch(cGrowthType)
    //    {
    //    case GrowthType.LOG:
    //        m_ExpNeeded += Mathf.Log(m_ExpNeeded);
    //        break;
    //    case GrowthType.EXPNENTIAL:
    //        m_ExpNeeded = (m_Level * m_Level) * 100;
    //        break;
    //    }

    //    m_HealthRegen   += (int)Mathf.Log(m_HealthRegen);
    //    m_MaxHealth     += (int)Mathf.Log(m_MaxHealth);
    //}
}
