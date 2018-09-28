using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    public bool ifBool;
    public int value;

    void Start()
    {
        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med

        if (value == 3)
        {
            print(3);
        }

        else if (value == 2)
        {
            print(2);
        }

        else
        {
            print("annat tal");
        }
    }

    void Update()
    {
        //ifBoll();
        movement();
    }

    void ifBoll()
    {
        if (ifBool == true)
        {
            print("ja");
        }

        else
        {
            print("nej");
        }
    }

    void movement()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("du tryckte walla");
        }
    }
}
