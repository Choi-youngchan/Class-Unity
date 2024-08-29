using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject[] cards = new GameObject[10];
    [SerializeField] Transform[] spawners;
    void Start()
    {
        for (int i = 0; i < cards.Length; i++) 
        {
            cards[i].transform.position = spawners[i].position;
        }

    }

    void Update()
    {
    }
}
