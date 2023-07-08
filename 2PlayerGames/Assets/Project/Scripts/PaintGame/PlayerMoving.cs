using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    private float speed = 5f;

    public void Move(float x, float y)
    {
        playerRb.velocity = new Vector2(x, y).normalized * speed;
    }
}
