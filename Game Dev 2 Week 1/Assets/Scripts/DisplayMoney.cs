using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{
    public Text myText;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Money: $" + player.GetComponent<Money>().funds;
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Money: $" + player.GetComponent<Money>().funds;
    }
}
