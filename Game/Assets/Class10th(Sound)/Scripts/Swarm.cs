using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : MonoBehaviour
{
    [SerializeField] AudioClip attackSound;
    [SerializeField] int deathCount;
    [SerializeField] Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
        
    }

    public void Die()
    {
        animator.SetBool("Die", true);
    }
    public void Release()
    {
        gameObject.SetActive(false);
    }
    public void OnDamage(int count)
    {
        deathCount += count;
        if (deathCount >= 5) 
        {
            Die();
        }
        SoundManager.Instance.Sound(attackSound);
    }
}
