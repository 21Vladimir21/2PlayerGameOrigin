using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Hello : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Helloo();

    [DllImport("__Internal")]
    private static extern void HelloString(string str);
    void Start()
    {
        Helloo();
        HelloString("Hello, world!");
        
    }

}
