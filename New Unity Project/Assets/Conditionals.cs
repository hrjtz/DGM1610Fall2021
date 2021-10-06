using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 75;
        int y = 14;

        if (y >= x)
        {
            Console.WriteLine("Hello World");
        }
        else
        {
            Console.WriteLine("Y is less than X.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
