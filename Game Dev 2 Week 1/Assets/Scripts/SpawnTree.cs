using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{
    public static float time;
    public bool determinant;
    [SerializeField]
    int timer;
    bool hasTimer = false;
    public GameObject tree;
    bool hasTree;
    public Transform spawnLocation;
    public GameObject Trees;
    public int treeMax = 0;
    // Update is called once per frame
    void Update()
    {
        if (treeMax <= 100)
        {
            time += Time.deltaTime;
            if (hasTimer == false)
            {
                timer = Mathf.FloorToInt(time) + Random.Range(0, 15);
                spawnLocation.position = new Vector3(Random.Range(-40f, 50f), transform.position.y, Random.Range(-50f, 40f));
                spawnLocation.eulerAngles = new Vector3(transform.eulerAngles.x, Random.Range(-180, 180), transform.eulerAngles.z);
                hasTimer = true;
            }
            if (time >= timer && Trees.transform.childCount < 10)
            {
                Instantiate(tree, spawnLocation.position, spawnLocation.rotation, Trees.transform);
                hasTimer = false;
                treeMax++;
            }
        }
       
    }
}
