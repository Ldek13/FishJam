using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckCard : MonoBehaviour
{

    public DeckBuilder deckBuilder;

    public GameObject MyCard;

    public GameObject Equippingbutton, UnequippingButton;

    public AnimeRE anime;

    // Start is called before the first frame update
    void Start()
    {
        deckBuilder = FindObjectOfType<DeckBuilder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToDeck()
    {
        if (deckBuilder.AddCard(MyCard))
        {
            Equippingbutton.SetActive(false);
            UnequippingButton.SetActive(true);
            anime.TriggerSet("Chosen");
        }

    }


    public void Unequip()
    {
        deckBuilder.RemoveCard(MyCard);
        Equippingbutton.SetActive(true);
        UnequippingButton.SetActive(false);
        anime.TriggerSet("UnChosen");
    }
}
