using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnieManager : MonoBehaviour
{
    public GameObject player;
    float money;
    public GameObject[] bernies;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        money = player.GetComponent<Money>().funds;  
        if(money < 200)
        {
            if(bernies[0].activeInHierarchy == false)
               bernies[0].SetActive(true);
        }
        if(money > 200 && money < 1000)
        {
            if (bernies[1].activeInHierarchy == false)
            {
                bernies[0].SetActive(false);
                bernies[1].SetActive(true);
            }
        }
        if(money > 1000 && money < 10000)
        {
            if (bernies[2].activeInHierarchy == false)
            {
                bernies[1].SetActive(false);
                bernies[2].SetActive(true);
            }
        }
        if(money > 10000)
        {
            if(bernies[3].activeInHierarchy == false)
            {
                bernies[3].SetActive(true);
                bernies[2].SetActive(false);
            }
        }
    }
}
