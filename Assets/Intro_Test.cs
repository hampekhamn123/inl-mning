using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Test : MonoBehaviour
{
    // int = heltal
    private int jumpForceWhileNotGrounded;

    // float = decimaltal med 7 siffror precision.
    public float george;

    // double = decimaltal med 15 siffror precision, används sällan i spel.
    public double yeet;

    // string = mening eller text
    public string minecraft;

    // bool = någonting som kan vara true/false (ja/nej)
    public bool john;

    // char = ett tecken
    public char dennis;

    public int JumpForceWhileNotGrounded
    {
        get
        {
            return jumpForceWhileNotGrounded;
        }

        set
        {
            jumpForceWhileNotGrounded = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        //PrintText();
        //Calculate();

    }

    void PrintText()
    {
        Debug.Log(minecraft);
        Debug.Log(JumpForceWhileNotGrounded + george);
    }

    void Calculate()
    {
        Debug.Log(5 + 5);
        Debug.LogError(
            Mathf.Sqrt(3245));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
