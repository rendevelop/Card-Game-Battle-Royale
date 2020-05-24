using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private static GameplayManager _instance;
    public static GameplayManager Instance{
        get{
            
            
            return _instance;
        }
    }


public bool phaseFinishedforNextState = false;
    public bool CardEffectOver = false;

        public State CurrentState;
    

     void Awake(){
        if(_instance == null)
        _instance = this;
        else{
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
     }


    
    void Start()
    {
        Board.Instance.Initialize();

        Cursor.Instance.MovetoTile(0,0);

        Board.Instance.GetTiles(4,0).PlaceCard(DebugCards[0], DebugCards[0].MaxHP,false, 0 );
        Board.Instance.GetTiles(5,2).PlaceCard(DebugCards[1], DebugCards[1].MaxHP,false, 0 );
        Board.Instance.GetTiles(2,3).PlaceCard(DebugCards[2], DebugCards[2].MaxHP,false, 0 );
        
    }

    public Card[] DebugCards = new Card[3];

  
    

    // Update is called once per frame
    void Update()
    {
        //CurrentState.UpdateState(this);
    }
    
    public void TransitionToState(State nextState){
        if(nextState != CurrentState){
            CurrentState = nextState;
        }
    }

   
}
