using UnityEngine;

public class FirstPlayerMove : PlayerMove
{
    override public void Move()
    {
        if (Input.GetKey(KeyCode.Z))
            PlayerRb.velocity = Vector2.up * PlayerSpeed;
        else
            PlayerRb.velocity = Vector2.down * PlayerSpeed;
    }
}

