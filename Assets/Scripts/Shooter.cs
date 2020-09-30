using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody bullet;
    public float power = 1500f;
    public float moveSpeed = 5f;
    Vector2 rotation = new Vector2 (0,0);
    public float speed = 3;

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += Input.GetAxis("Mouse Y");
        //float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //transform.Translate (h, 0, v);
        transform.eulerAngles = (Vector2)rotation * speed;
        if (Input.GetButtonUp ("Fire1")) 
        {
            Rigidbody instance = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 forward = transform.TransformDirection (Vector3.forward);
            instance.AddForce(forward * power);
        }
        
    }
}
