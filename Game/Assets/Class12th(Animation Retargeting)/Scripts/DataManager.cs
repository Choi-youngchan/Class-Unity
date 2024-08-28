using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] ScoreUI scoreUI;

    void Awake()
    {
        Load();
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
    public void ResetScore()
    {
        score = 0;
        Save();
        // PlayerPrefs.DeleteAll();
        // Load();
    }
    public void IncreaseScore()
    {
        int random = UnityEngine.Random.Range(5, 11);
        score += random;

        scoreUI.OnUpdate(random);
        PlayerPrefs.SetInt("Score", score);
    }
}
