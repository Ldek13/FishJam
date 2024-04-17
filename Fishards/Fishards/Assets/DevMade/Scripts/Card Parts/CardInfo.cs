using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardInformation", fileName = "CardInfo_")]
public class CardInfo : ScriptableObject
{
    [Header("All of this is to be set by Inspector")]

    //Type of the card
    public string CardType;

    public float CardStrength;

    public GameObject CardObject;       //An object this card posesses [ originally used to save buildings to spawn ]
    
}