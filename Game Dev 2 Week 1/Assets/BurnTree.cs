using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTree : MonoBehaviour
{
    public ParticleSystem[] burningParticles;
    int i = 0;
    // Start is called before the first frame update
    private void OnParticleCollision(GameObject other)
    {
        if (i < burningParticles.Length)
        {
            print("AHHHHHHHHH");
            burningParticles[i].gameObject.SetActive(true);
            i++;
            GameObject.Find("Player").GetComponent<Money>().AddFunds(10);
        }
    }
}

