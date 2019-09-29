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
    bool Dead = false;
    float timer = 2.5f;
    public GameObject leaves;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 1000f;
        CurrentHealth = MaxHealth;


    }

    // Update is called once per frame
    void Update()
    {
        if(Dead == true)
        {
            timer -= Time.deltaTime;
            
            if (timer < 0)
            {
                    Destroy(gameObject);
            }
        }
    }

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        if (CurrentHealth <= 0 && Dead == false)
        {
            Die();
            Dead = true;
        }
    }

    void Die()
    {
        CurrentHealth = 0;
        GameObject.Find("Player").GetComponent<Money>().AddFunds(100);
        burningParticles[i].gameObject.SetActive(true);
        for(int k = 0; k < transform.childCount; k++)
        transform.GetChild(k).GetComponent<Animator>().SetBool("IsDead", true);
        //transform.GetChild(1).GetComponent<Animator>().SetBool("IsDead", true);
    }

    private void OnParticleCollision(GameObject other)
    {
        DealDamage(10f);
        differenceInHealth = (MaxHealth - ((((float)i + 1) / burningParticles.Length) * MaxHealth));
        if (CurrentHealth < differenceInHealth && CurrentHealth > 0)
        {
            burningParticles[i].gameObject.SetActive(true);
            i++;
            GameObject.Find("Player").GetComponent<Money>().AddFunds(10);
        }


    }


}

