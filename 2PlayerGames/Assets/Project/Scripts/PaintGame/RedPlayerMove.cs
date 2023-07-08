using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerMove : PlayerMoving
{
    void FixedUpdate()
    {
        Move(Input.GetAxis("2Horizontal"), Input.GetAxis("2Vertical"));
    }
}
