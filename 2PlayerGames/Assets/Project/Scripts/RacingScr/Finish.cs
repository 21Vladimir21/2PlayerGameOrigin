using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public static UnityEvent BlueWin = new UnityEvent(), RedWin = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BluePlayer"))
            BlueWin.Invoke();
        if (other.CompareTag("RedPlayer"))
            RedWin.Invoke();
    }
}
