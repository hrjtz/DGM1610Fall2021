using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        while (a <= 10)
        {
            Console.Writeline(a);
            a++;
        }

        int b = 0;
        do
        {
            Console.Writeline(b);
        }
        while (a <= 14)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
