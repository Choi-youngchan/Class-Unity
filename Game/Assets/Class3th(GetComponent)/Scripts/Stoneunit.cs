using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Move))]
public class Stoneunit : MonoBehaviour
{
    
    [SerializeField] private Move move;

    private void Awake()
    {
        move = GetComponent<Move>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(new Vector3(0,0,1));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(new Vector3(0, 0, -1));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            move.OnMove(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(Vector3.right);
        }
    }
}
