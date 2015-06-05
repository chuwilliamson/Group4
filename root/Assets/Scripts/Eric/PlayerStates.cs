using UnityEngine;
using System.Collections;

public class PlayerStates : MonoBehaviour
{
   

   public enum eStates
    {   
       Init,
       Idle,
       Walking,
       Running,
       Crouching,
       Jumping,
       Slapping,
       Attacking,
    }

    public eStates cState = eStates.Idle;

    void Update ()
    {
        switch(cState)
        {
            case eStates.Idle:
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.C))
                    cState = eStates.Running;
                if (Input.GetKeyDown(KeyCode.V))
                    cState = eStates.Crouching;
                if (Input.GetKeyDown(KeyCode.B))
                    cState = eStates.Jumping;
                if (Input.GetKeyDown(KeyCode.N))
                    cState = eStates.Slapping;
                if (Input.GetKeyDown(KeyCode.M))
                { cState = eStates.Attacking; }
                
                break;

            case eStates.Walking:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.C))
                    cState = eStates.Running;
                if (Input.GetKeyDown(KeyCode.V))
                    cState = eStates.Crouching;
                if (Input.GetKeyDown(KeyCode.B))
                    cState = eStates.Jumping;
                if (Input.GetKeyDown(KeyCode.M))
                    cState = eStates.Attacking;
                break;

            case eStates.Running:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.B))
                    cState = eStates.Jumping;
                if (Input.GetKeyDown(KeyCode.N))
                    cState = eStates.Slapping;
                break;

            case eStates.Crouching:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.M))
                    cState = eStates.Attacking;
                break;

            case eStates.Jumping:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.C))
                    cState = eStates.Running;
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.N))
                    cState = eStates.Slapping;
                break;

            case eStates.Slapping:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.C))
                    cState = eStates.Running;
                break;

            case eStates.Attacking:
                if (Input.GetKeyDown(KeyCode.Z))
                    cState = eStates.Idle;
                if (Input.GetKeyDown(KeyCode.X))
                    cState = eStates.Walking;
                if (Input.GetKeyDown(KeyCode.C))
                    cState = eStates.Running;
                if (Input.GetKeyDown(KeyCode.B))
                    cState = eStates.Jumping;
                break;
        }
    }
}
