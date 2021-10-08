using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] fruit = {"apple", "banana", "kiwi", "strawberry"};
        foreach (string a in fruit)
        {
            Console.Writeline(a);
        }

        int[] MyNums = {4, 2, 10, 12, 11};
        foreach (int b in MyNums)
        {
            Console.Writeline(b);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
