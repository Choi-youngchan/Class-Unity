using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postbox : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Click");
        }
    }
}
