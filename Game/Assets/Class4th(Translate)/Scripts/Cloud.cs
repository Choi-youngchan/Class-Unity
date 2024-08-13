using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    Vector3 direction;
    [SerializeField ]float speed = 2;
    // public void ResetPosition()
    // {
    //     // int random = Random.Range(0, PositionManager.spawners.Length);
    //     // direction = spawners[random].position;
    // }

    void Start()
    {
        transform.position = new Vector3(0, 0, 30);
    }

    void Update()
    {
        direction.z = direction.z - speed * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        // transform.Translate();
    }
}
