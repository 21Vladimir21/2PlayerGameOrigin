using System.Collections;
using System.Collections.Generic;
using UnityEngine;
abstract public class PlayerMove : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D PlayerRb;
    [SerializeField] protected float PlayerSpeed = 3;
    void Update()
    {
        Move();
    }

    abstract public void Move();
}
