using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] fruit = {"apple", "banana", "kiwi", "strawberry"};
        for (int a = 0; a < fruit.Length; a++)
        {
            Console.Writeline(fruit[a]);
        }
        int[] MyNums = {4, 2, 10, 12, 11};
        for (int b = 0; b < MyNums.Length; b++)
        {
            Console.Writeline(MyNums[a]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
