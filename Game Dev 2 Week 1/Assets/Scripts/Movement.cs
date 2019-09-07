using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5.0f;
    public float sensitivity = 10f;
    private Vector2 currentRotation;

    public ParticleSystem flameThrower;
    private void Start()
    {
        flameThrower.Stop();
    }
    private void Update()
    {
        Move();
        RotateObject();
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetMouseButtonDown(0))
        {
            flameThrower.Play();
        }
        if(Input.GetMouseButtonUp(0))
        {
            flameThrower.Stop();
        }
        print(flameThrower.isPlaying);
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    private void RotateObject()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        gameObject.transform.rotation = Quaternion.Euler(0, currentRotation.x, 0);
    }
}
