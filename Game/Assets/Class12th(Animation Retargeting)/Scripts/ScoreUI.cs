using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }
    public void OnUpdate(int random)
    {
        scoreText.text = "Score up\n" + random.ToString();
    }
}
