using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    private SpriteRenderer Square;
    [SerializeField] private Color BlueColor;
    [SerializeField] private Color RedColor;
    public bool ImBlue;
    public bool ImRed;

    void Start()
    {
        Square = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BluePlayer"))
        {
            Square.color = BlueColor;
            ImBlue = true;
            ImRed = false;
        }

        if (other.CompareTag("RedPlayer"))
        {
            Square.color = RedColor;
            ImBlue = false;
            ImRed = true;
        }
    }


}
