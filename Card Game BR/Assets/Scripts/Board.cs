using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private static Board _instance;
    public static Board Instance{
        get{
            
            
            return _instance;
        }
    }

    
    Tiles[,] tileBoard;
    public int xLength;
    public int yLength;

    public int DefaultTerrainType;
    public GameObject TilePrefab;

    

     void Awake(){
        if(_instance == null)
        _instance = this;
        else{
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
     }

     public void Initialize(){
         tileBoard = new Tiles[xLength,yLength];

         

         for(int i = 0; i<xLength; i++){
            for (int e = 0; e<yLength; e++){

                GameObject Go = Instantiate(TilePrefab);
                Vector3 TilePosition = new Vector3(2*i, 2*e,0);
                
                Go.transform.position = TilePosition;
                tileBoard[i,e] = Go.GetComponent<Tiles>();
                tileBoard[i,e].tilePosition = TilePosition;
                tileBoard[i,e].SetTileTerrain(Random.Range(0,4));

            }
         }
     }

     public Tiles GetTiles(int x, int y){
         return tileBoard[x,y];
     }


}
