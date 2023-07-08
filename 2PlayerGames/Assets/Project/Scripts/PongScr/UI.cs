using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] TMP_Text FirtsPlayerScore;
    [SerializeField] TMP_Text SecondPlayerScore;

    private void Update()
    {
        FirtsPlayerScore.text = Convert.ToString(scoreManager.FirstPlayerScore);
        SecondPlayerScore.text = Convert.ToString(scoreManager.SecondPlayerScore);
    }
}
