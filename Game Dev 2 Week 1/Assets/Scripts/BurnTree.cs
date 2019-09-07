using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTree : MonoBehaviour
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    float differenceInHealth;
    public ParticleSystem[] burningParticles;
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 1000f;
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
        GameObject.Find("Player").GetComponent<Money>().AddFunds(100);
        Debug.Log("you dead");
        transform.GetChild(0).GetComponent<Animator>().SetBool("IsDead", true);
        transform.GetChild(1).GetComponent<Animator>().SetBool("IsDead", true);

        //gameObject.SetActive(false);
    }

    private void OnParticleCollision(GameObject other)
    {
        DealDamage(10f);
        differenceInHealth = (MaxHealth - ((((float)i + 1) / burningParticles.Length) * MaxHealth));
        print(burningParticles.Length);
        print("difference in health " + differenceInHealth);
        if (CurrentHealth < differenceInHealth)
        {
            print("AHHHHHHHHH");
            burningParticles[i].gameObject.SetActive(true);
            i++;
            GameObject.Find("Player").GetComponent<Money>().AddFunds(10);
        }


    }

}

