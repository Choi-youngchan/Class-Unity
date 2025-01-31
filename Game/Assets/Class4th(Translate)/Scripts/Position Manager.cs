using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PositionManager : MonoBehaviour
{
    [SerializeField] Transform[] spawners;
    [SerializeField] GameObject Cloud;
    void Start()
    {
        InvokeRepeating("ResetPosition", 2.0f,  2.0f);
    }
    public void ResetPosition()
    {
        int random = Random.Range(0, spawners.Length);

        
        Cloud.transform.position = spawners[random].position;
    }
}
