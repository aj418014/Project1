using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnGround : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        GetComponent<Material>().color = Color.blue;
    }

}
