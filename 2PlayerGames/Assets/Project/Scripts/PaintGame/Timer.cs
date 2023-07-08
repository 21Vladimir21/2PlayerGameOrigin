using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeStart = 30;
    [SerializeField] TMP_Text timertext;
    private bool timerRunnong = true;
    public bool Complited;

    private void OnEnable()
    {
        timertext.text = timeStart.ToString();
        Update();
    }


    void Update()
    {
        if (timerRunnong == true)
        {
            timeStart -= Time.deltaTime;
            timertext.text = Mathf.Round(timeStart).ToString();

            if (timeStart < 0)
            {
                timeStart = 0;
                Complited = true;
            }

        }
    }
}
