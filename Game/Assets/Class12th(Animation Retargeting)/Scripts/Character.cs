using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent UnityEvent;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                if (UnityEvent != null)
                {
                    UnityEvent.Invoke();
                }

                animator.Rebind();
                Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
            }
        }
    }
}
