using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerPaint : MonoBehaviour
{
    [SerializeField] ScoreManagerPaintRed scoreManagerPaint;
    public int score;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<SwitchColor>().ImBlue != true && other.gameObject.GetComponent<SwitchColor>().ImRed != true)
        {
            score++;
        }
        if (other.gameObject.GetComponent<SwitchColor>().ImRed == true)
        {
            score++;
            scoreManagerPaint.score--;
            Debug.Log("123");
        }

    }

}
