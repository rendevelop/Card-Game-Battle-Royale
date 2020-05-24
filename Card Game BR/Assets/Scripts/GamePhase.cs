using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GamePhase : ScriptableObject
{
    public bool ActPhase(GameplayManager controller){
        DoActions(controller);
        return DoPhaseShifting(controller);
    }

    public Actions[] acts;
    public PhaseShift[] phases;
     public void DoActions(GameplayManager controller){
        for (int i = 0; i<acts.Length; i++){
            acts[i].Act(controller); //Do actions gathers all actions and loops through them and executes them.


        }

    }

     public bool DoPhaseShifting(GameplayManager controller){
         bool finalValue = true;
        for (int i = 0; i<phases.Length; i++){
            finalValue = phases[i].ShiftPhases(controller); //all conditions must be true to go to the next one
            if (finalValue == false){
                return false;
            }

        }
        return finalValue;
    }
}
