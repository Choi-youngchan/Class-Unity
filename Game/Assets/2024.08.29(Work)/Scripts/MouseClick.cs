using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] LayerMask layerMask;
    [SerializeField] IInteractable interactable;
    [SerializeField] GameObject[] targets;
    [SerializeField] float time;
    [SerializeField] int count;
    [SerializeField] Text times;
    [SerializeField] GameObject realtime;
    [SerializeField] Text scoreTimes;
    [SerializeField] GameObject scoretime1;
    [SerializeField] GameObject overText;
    [SerializeField] GameObject winText;

    float scoreTime = 0;




    private void Awake()
    {
        time = 30f;
    }
    void Start()
    {
        targets = new GameObject[2];
        times.text = time.ToString();
        count = 5;
    }
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        times.text = time.ToString();
        if (time < 0) 
        {
            times.text = "0";
            overText.SetActive(true);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayCastHit, Mathf.Infinity, layerMask))
            {
                if (targets[0] == null)
                {
                    targets[0] = rayCastHit.collider.gameObject;
                }
                else if (targets[1] == null)
                {
                    targets[1] = rayCastHit.collider.gameObject;
                }
            }
        }
        if(targets[0] != null && targets[1] != null)
        {
            if (targets[0].layer == targets[1].layer && targets[0]!= targets[1])
            {
                Destroy(targets[0]);
                Destroy(targets[1]);
                count--;
                if(count == 0)
                {
                    winText.SetActive(true);
                    realtime.SetActive(false);
                    scoreTime = time;
                    time = 0;
                    scoreTimes.text = scoreTime.ToString();
                    scoretime1.SetActive(true);
                }
            }
            else
            {
                targets[0] = null;
                targets[1] = null;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 0.5f);
    }

}
