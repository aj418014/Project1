using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public float funds = 0;

    public void AddFunds(float reward)
    {
        funds += reward;
    }

}
