using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    [SerializeField] GameObject selectIcon;
    public void OnEnter()
    {
        selectIcon.SetActive(true);
    }
    public void OnExit()
    {
        selectIcon.SetActive(false);
    }
}
