using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFinalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        scoreText.text = "You Died! Final Score: " + finalScore;
    }
}
