using UnityEngine;

public class BluePlayerMove : PlayerMoving
{
    private void FixedUpdate()
    {
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}