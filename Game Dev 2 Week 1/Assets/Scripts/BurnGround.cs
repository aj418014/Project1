using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnGround : MonoBehaviour
{
    public GameObject player;
    bool alreadyBurned = false;
    private void Start()
    {
    }
    private void OnParticleCollision(GameObject other)
    {
        
        print("Burn Ground");
        GetComponent<Animator>().Play("Ground Burning");
        if (alreadyBurned == false)
        {
            player.GetComponent<Money>().AddFunds(50);
            alreadyBurned = true;
        }
    }

}
