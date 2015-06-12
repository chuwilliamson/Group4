using UnityEngine;
using System.Collections;

public class TurretActions : MonoBehaviour, TActions
{
    protected static TurretActions t_instance;
    private TurretFSM t_fsm;

    void OnTriggerStay(Collider c)
    {
        //if(c.GetComponent<Stats>().)
    }

    void Awake()
    {
        t_fsm = new TurretFSM();
        t_instance = this;
    }

    public void Reload()
    {
        if (t_fsm.TurretActions["reload"] == true)
            print("Im Reloading");
    }

    public void OnTriggerStay(Collider c)
    {

    }

    public void tState(TurretState state)
    {
        t_fsm.t_ChangeState(state);
    }

    public static TurretActions TInstance
    {
        get
        {
            return t_instance;
        }
    }
}
