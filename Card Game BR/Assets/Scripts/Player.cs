using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> Deck = new List<Card>();

    public Card[] Hand = new Card[5];
    public int HP;
    public int currentMana;
}
