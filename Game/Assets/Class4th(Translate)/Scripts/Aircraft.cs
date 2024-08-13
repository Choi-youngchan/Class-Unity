using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 1.00f;
    void Start()
    {
        
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // ������ ����ȭ
        direction.Normalize();
        
        // P = P0 + vt
        // Time.deltaTime : ������ �������� �Ϸ�� �� ����� �ð��� �� ������ ��ȯ�ϴ� ���Դϴ�.
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
