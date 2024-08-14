using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    Vector3 direction;
    [SerializeField ]float speed = 10.0f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 30);
    }

    void Update()
    {
        // direction.z = direction.z - speed * Time.deltaTime;
        // transform.position += direction * Time.deltaTime;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
