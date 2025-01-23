using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    [Header ("Pay to Bills")]
    public int Pay = 0;

    [SerializeField] private int num20;//variables for number of each type of bill
    [SerializeField] private int num5;
    [SerializeField] private int num1;

    public void Start()
    {
        num20 = Pay / 20;//math done here
        Pay = Pay - (num20 * 20);
        num5 = Pay / 5;
        Pay = Pay - (num5 * 5);
        num1 = Pay / 1;

        Debug.Log("number of 20s " + num20);//display outcomes to console
        Debug.Log("number of 5s "+ num5);
        Debug.Log("number of 1s " + num1);
    }

}
