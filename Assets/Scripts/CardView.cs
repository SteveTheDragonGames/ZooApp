using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImage;

    public CardModel[] cards;

    public void ShowCard(int cardNumber)
    {

        title.text = cards[cardNumber].title;
        description.text = cards[cardNumber].description;
        exhibit.text = cards[cardNumber].exhibit;
        animalImage.sprite = cards[cardNumber].animalImage;
    }

}


