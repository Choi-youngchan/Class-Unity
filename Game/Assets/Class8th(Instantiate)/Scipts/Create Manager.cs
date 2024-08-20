using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    [SerializeField] GameObject cloneObject;
    [SerializeField] int count = 0;
    void Start()
    {
        StartCoroutine(Create());
    }
    IEnumerator Create()
    {
         while (count < 4)
         {
            if (cloneObject == null)
            {
                cloneObject = Instantiate(prefabs[count]);
                count++;
            }
            yield return new WaitForSeconds(5.0f);
         }

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(cloneObject);
        }
    }
    // float B = 0;
    // public void InstantiatePerTime()
    // {
    //     B += Time.deltaTime;
    //     if (B >= 5.0f)
    //     {
    //         Debug.Log("Instance");
    //         cloneObject = Instantiate(prefab);
    //         cloneObject.transform.position = new Vector3(0,0,0);
    //         B = 0;
    //     }
    // }
}
