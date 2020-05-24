using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName= "New Card", menuName = "New Card")]
public class Card : ScriptableObject 
{
    public string cardName;
    public string effectDescription;
    public Color cardColor;
    public int MaxHP;
    public int ManaCost;
    public int Attack;
    public int Type;
    public Effect effect;
    public bool HasEffect;
    public Sprite CardPicture;

}
