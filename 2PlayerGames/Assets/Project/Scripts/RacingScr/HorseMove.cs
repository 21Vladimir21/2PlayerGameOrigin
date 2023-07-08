using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D FirtsPlayerRb;
    [SerializeField] private Rigidbody2D SecondPlayerRb;
    private float firstSpeed;
    private float secondSpeed;
    private float multiplier = 0.5f;


    void Update()
    {
        FirtsPlayerRb.velocity = Vector2.up * firstSpeed;
        SecondPlayerRb.velocity = Vector2.up * secondSpeed;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            firstSpeed += multiplier;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            secondSpeed += multiplier;
        }
    }
}
