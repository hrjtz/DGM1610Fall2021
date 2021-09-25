using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string myName;

    void Start ()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}
