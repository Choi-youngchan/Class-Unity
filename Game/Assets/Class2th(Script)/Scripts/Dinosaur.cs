using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    private void Awake()
    {
        // Awake()�Լ�
        // ���� ������Ʈ�� ������ ���Ŀ� ȣ��Ǵ� �Լ���, �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ���� ����˴ϴ�.

        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        // OnEnable() �Լ�
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �Լ� �Դϴ�.
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start()�Լ�
        // ���� ������Ʈ�� ������ �Ŀ� ȣ��Ǵ� �Լ���, �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� Ȱ��ȭ�� ������ ���� ȣ��˴ϴ�.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate() �Լ�
        // Timestep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("FixedUpdate");
    }

    void Update()
    {
        // Update() �Լ�
        // �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        // LateUpdate() �Լ�
        // Update �Լ��� �� ������, ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("LateUpdate");
    }
    private void OnDisable()
    {
        // OnDisable() �Լ�
        // ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        // OnDestroy() �Լ�
        // ���� ������Ʈ�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDestroy");
    }
}
