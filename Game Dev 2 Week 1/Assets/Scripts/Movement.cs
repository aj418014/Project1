using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5.0f;
    public float sensitivity = 10f;
    private Vector2 currentRotation;
    public GameObject player;
    public GameObject flameThrower;
    private void Update()
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
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360); 
        gameObject.transform.rotation = Quaternion.Euler(0, currentRotation.x, 0);
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Space))
        {
            print("button is down");
            flameThrower.GetComponent<ParticleSystem>().Play();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            print("up");
            // flameThrower.GetComponent<ParticleSystem>().Pause();
        }
    }
}
