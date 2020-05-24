using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICard : MonoBehaviour
{
    public Image selfImage;
    Card usedCard;
    public Text CardName;
    public Text Attack;
    public Text HP;
    public GameObject[] ManaPoints = new GameObject[12];
    public GameObject[] Type = new GameObject[5];
    public Image Portrait;


    public void UpdateCard(Card newCard, int currentHP){
        
        usedCard = newCard;

        selfImage.color = usedCard.cardColor;
        CardName.text = usedCard.cardName;
        Attack.text = usedCard.Attack+"";
        HP.text = currentHP + "/" + usedCard.MaxHP;
        Portrait.sprite = usedCard.CardPicture;

        for (int i = 0; i<ManaPoints.Length; i++){
            if(i < usedCard.ManaCost)
            ManaPoints[i].SetActive(true);
            else
            ManaPoints[i].SetActive(false);
        }

        for (int i = 0; i<Type.Length; i++){
            if(i == usedCard.Type)
            Type[i].SetActive(true);
            else
            Type[i].SetActive(false);
        }



    }
    
}
