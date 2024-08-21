using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public enum State
{
    WALK,
    ATTACK,
    DIE
}
public class Knight : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject knight;
    [SerializeField] float speed = 2.5f;
    [SerializeField] State state;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        state = State.WALK;
    }

    public void Walk()
    {
        animator.SetBool("attack", false);
        knight.transform.Translate(Vector3.forward *speed * Time.deltaTime);
    }
    public void Attack()
    {
        animator.SetBool("attack", true);
    }
    public void Die()
    {
        animator.Play("Die");
    }
    void Update()
    {
        switch(state)
        {
            case State.WALK: Walk();
                break;
            case State.ATTACK: Attack(); 
                break;
            case State.DIE: Die(); 
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.ATTACK;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.DIE;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter : �������� �浹�� �Ͼ�� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay : �������� �浹�� �ϰ� �ִ� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit : �������� �浹�� ������ �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnCollisionExit");
    }
}
