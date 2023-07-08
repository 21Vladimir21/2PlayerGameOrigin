using UnityEngine;


public class SecondPlayerMove : PlayerMove
{
    override public void Move()
    {
        if (Input.GetKey(KeyCode.M))
            PlayerRb.velocity = Vector2.up * PlayerSpeed;
        else
            PlayerRb.velocity = Vector2.down * PlayerSpeed;
    }
}
