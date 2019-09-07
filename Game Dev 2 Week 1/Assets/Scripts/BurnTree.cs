using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTree : MonoBehaviour
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }

    public ParticleSystem[] burningParticles;
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 40f;
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        Debug.Log(CurrentHealth);
        if (CurrentHealth <= 0)
            Die();
    }

    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("you dead");
        gameObject.SetActive(false);
    }

    private void OnParticleCollision(GameObject other)
    {
        DealDamage(1f);
        if (i < burningParticles.Length)
        {
            print("AHHHHHHHHH");
            burningParticles[i].gameObject.SetActive(true);
            i++;
            GameObject.Find("Player").GetComponent<Money>().AddFunds(10);
        }
    }

}

