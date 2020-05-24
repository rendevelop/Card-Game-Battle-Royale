using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : ScriptableObject
{
    public List<CardPhase> phasequeue = new List<CardPhase>();
    
    // Start is called before the first frame update
    public void UpdateState(Tiles controller){
        DoPhases(controller);
        
    }
    int startingPhase = 0;

    public void DoPhases(Tiles controller){
        
            bool MovetoNext = phasequeue[startingPhase].ActPhase(controller); 
            if(MovetoNext) startingPhase ++;
            if(startingPhase == phasequeue.Count) GameplayManager.Instance.CardEffectOver = true;
            

    }

    
}
