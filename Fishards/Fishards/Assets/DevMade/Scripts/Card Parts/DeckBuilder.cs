using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilder : MonoBehaviour
{

    public DeckManager deckManager;

    public float CardLimit;
    public float CurrentCards;

    public List<GameObject> NewDeck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AddCard(GameObject Card)
    {
        if(CurrentCards < CardLimit)
        {
            NewDeck.Add(Card);
            CurrentCards++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void RemoveCard(GameObject Card)
    {
        NewDeck.Remove(Card);
        CurrentCards--;
    }

    public void ConfrimCards()
    {
        deckManager.CardsInDeck = NewDeck;

    }
}
