using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewCard", menuName="Cards")]
public class CardModel : ScriptableObject
{
    public string title;
    public string description;
    public string exhibit;
    public Sprite animalImage;
}
