using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CardPhase : ScriptableObject
{
    public bool ActPhase(Tiles controller){
        DoActions(controller);
        return DoPhaseShifting(controller);
    }

    public CardAction[] acts;
    public CardPhaseShift[] phases;
     public void DoActions(Tiles controller){
        for (int i = 0; i<acts.Length; i++){
            acts[i].CardAct(controller); //Do actions gathers all actions and loops through them and executes them.


        }

    }

     public bool DoPhaseShifting(Tiles controller){
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
