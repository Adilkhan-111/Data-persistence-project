using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text BestScoreText;
    private void Awake()
    {
        BestScoreText.text = "Best Score: " + GameManager.instance.TempPlayer + " : " + GameManager.instance.HighScoreNum;
    }
}
