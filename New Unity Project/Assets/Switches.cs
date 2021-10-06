using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myNum = 2;
        switch (myNum)
        {
            case 1:
                Console.Writeline("Hi");
                break;
            case 2:
                Console.Writeline("there");
                break;
            case 3:
                Console.Writeline("freind");
                break;
            default:
                Console.Writeline("Select number to find word in sentence");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
