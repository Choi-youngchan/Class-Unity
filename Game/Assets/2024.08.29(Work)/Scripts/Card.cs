using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour , IInteractable
{
    public void Interactable()
    {
        gameObject.SetActive(false);
    }
}
