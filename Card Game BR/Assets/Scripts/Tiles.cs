using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    int TerrainType;

    public Card isCard;
    public int currentCardHP;
    public Player isPlayer;
    public bool FacingUp = false;
    
    public int Ownership;
    public bool hasActed;

    public Vector3 tilePosition;

    public Sprite DefaultTerrain;
    public Sprite GrassTerrain;
    public Sprite LavaTerrain;
    public Sprite WaterTerrain;

    public SpriteRenderer SR;
    public GameObject PlayerActive;
    public GameObject CardActive;
    public GameObject ShowHPBar;
    public GameObject HPBar;
    public GameObject faceUp;
    public GameObject faceDown;
    public GameObject highlight;
    public GameObject Attack;

    

    public void SetTileTerrain(int terrain){
        TerrainType = terrain;
        switch(terrain){
            case 0:
            //Default tile
            SR.sprite = DefaultTerrain;
            break;
            case 1:
            SR.sprite = LavaTerrain;
            //Fire Tile
            break;
            case 2:
            SR.sprite = WaterTerrain;

            //Water Tile
            break;
            case 3:
            SR.sprite = GrassTerrain;
            //Grass Tile
            break;
            default:
            break;

        }
    }

    public void PlaceCard(Card placedCard, int hp, bool facing, int Owner){
        if(isCard==null && isPlayer == null){
            isCard = placedCard;
            CardActive.SetActive(true);
            currentCardHP = hp;
            ShowHPBar.SetActive(true);
            FacingUp = facing;
            HPBar.transform.localScale = new Vector3((float)currentCardHP/isCard.MaxHP,1,1);

            if(facing){
                faceUp.SetActive(true);
                faceDown.SetActive(false);
            }
            else{
                faceUp.SetActive(false);
                faceDown.SetActive(true);
            }
            Ownership = Owner;
        }
    }
    public void ChangePos(bool facing){
        FacingUp = facing;
        if(facing){
                faceUp.SetActive(true);
                faceDown.SetActive(false);
            }
            else{
                faceUp.SetActive(false);
                faceDown.SetActive(true);
            }
    }
    

    private void Update() {
        if(Cursor.Instance.CancelAllHighlights)
        StopHighlighting();
    }
    public void RemoveCard(){
        isCard = null;
        CardActive.SetActive(false);
        ShowHPBar.SetActive(false);
    }
    public void PlacePlayer(Player thisPlayer){
        if(isPlayer==null && isCard == null){
            isPlayer = thisPlayer;
            PlayerActive.SetActive(true);
        }
    }
    public void RemovePlayer(){
        isPlayer = null;
        PlayerActive.SetActive(false);
    }

    public void UpdateHP(int hp){
        currentCardHP += hp;
        HPBar.transform.localScale = new Vector3((float)currentCardHP/isCard.MaxHP,1,1);
        if(currentCardHP == 0){
            RemoveCard();
        }
    }

    
    public void StopHighlighting(){
        highlight.SetActive(false);
        Attack.SetActive(false);
    }
}
