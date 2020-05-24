using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : ScriptableObject
{

    public List<GamePhase> phasequeue = new List<GamePhase>();
    public Transition[] transitions;
    // Start is called before the first frame update
    public void UpdateState(GameplayManager controller){
        DoPhases(controller);
        CheckTransitions(controller);
    }
    int startingPhase = 0;

    public void DoPhases(GameplayManager controller){
        
            bool MovetoNext = phasequeue[startingPhase].ActPhase(controller); 
            if(MovetoNext) startingPhase ++;
            

    }

    void CheckTransitions(GameplayManager controller){
        for (int i = 0; i< transitions.Length;i++){
            bool decisionSucceeded = transitions[i].decision.Decide(controller);
            if(decisionSucceeded){
                controller.TransitionToState(transitions[i].trueState);
            }
            else{
                controller.TransitionToState(transitions[i].falseState);
            }
        }
        
    }
}
