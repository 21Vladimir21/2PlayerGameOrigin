using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerPaintRed : MonoBehaviour
{
    [SerializeField] ScoreManagerPaint scoreManagerPaint;
    [HideInInspector] public int score;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<SwitchColor>().ImRed == false && other.gameObject.GetComponent<SwitchColor>().ImBlue != true)
        {
            score++;
        }
        if (other.gameObject.GetComponent<SwitchColor>().ImBlue == true)
        {
            score++;
            scoreManagerPaint.score--;
        }

    }
}
