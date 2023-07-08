using UnityEngine;
using TMPro;
using System;

public class UIpaint : MonoBehaviour
{
    [SerializeField] private ScoreManagerPaint BlueScoreManager;
    [SerializeField] private ScoreManagerPaintRed RedScoreManager;
    [SerializeField] private TMP_Text BlueScoreText;
    [SerializeField] private TMP_Text RedScoreText;

    private void Update()
    {
        BlueScoreText.text = Convert.ToString(BlueScoreManager.score);
        RedScoreText.text = Convert.ToString(RedScoreManager.score);
    }
}
