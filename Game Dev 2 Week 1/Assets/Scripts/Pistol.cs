﻿using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10f;

    public Camera fpsCam;
    public ParticleSystem pew;
    public AudioSource bang;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        pew.Play();
        bang.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
