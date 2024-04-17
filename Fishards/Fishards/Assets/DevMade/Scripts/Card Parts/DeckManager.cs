using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{

    public List<GameObject> CardsInDeck;        //Cards chosen for a deck
    public List<GameObject> CurrentDeck;        //A current deck drawn in a random order
    public List<GameObject> InGameDeck;        //A representation of the current deck with cards turned upside down

    public Transform CardCanvas;

    public Transform SpawnPosition;     //Position for spawning cards

    public float DeckOffset;

    public ParticleSystem RefillEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawDeck()
    {
        RefillEffect.Play();
        CurrentDeck.Clear();
//        CurrentDeck = new List<GameObject>(CardsInDeck.Count);
        for(int i = 0; i < CardsInDeck.Count; i++)
        {
            Debug.Log(i);
            CurrentDeck.Add(null);
        }

        foreach(GameObject card in CardsInDeck)
        {
            int random = Random.Range(0, CardsInDeck.Count);
            if(CurrentDeck[random] == null)
            {
                CurrentDeck[random] = card;
            }
            else
            {
                for(int i = 0; i < CardsInDeck.Count; i++)
                {
                    if(CurrentDeck[i] == null)
                    {
                        CurrentDeck[i] = card;
                        break;
                    }
                }
            }
        }

        float CurrentOffset = 0;
        InGameDeck.Clear();
        foreach(GameObject card in CurrentDeck)
        {
            InGameDeck.Add(Instantiate(card.GetComponent<CardMain>().MyAction.CardBack,  SpawnPosition.transform.position + new Vector3(CurrentOffset, CurrentOffset), Quaternion.identity, SpawnPosition.transform));
            CurrentOffset += DeckOffset;
        }

    }
    public void DrawCards(int Amount)
    {
        if(CurrentDeck.Count < 1)
        {
            DrawDeck();
        }

        for(int i = 0; i < Amount;  i++)
        {
            
            GameObject DrawnCard = CurrentDeck[CurrentDeck.Count - 1];
            CurrentDeck.RemoveAt(CurrentDeck.Count - 1);
            CurrentDeck.TrimExcess();
            /*
            float SpawnXRandomization = Random.Range(-SpawnSize, SpawnSize);
            float SpawnYRandomization = Random.Range(-SpawnSize, SpawnSize);
            */

            
            Instantiate(DrawnCard, InGameDeck[InGameDeck.Count - 1].transform.position, Quaternion.identity, CardCanvas);
            Destroy(InGameDeck[CurrentDeck.Count]);
            InGameDeck.RemoveAt(CurrentDeck.Count);
            InGameDeck.TrimExcess();
        }

    }

}
