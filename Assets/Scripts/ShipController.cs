using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 move;
    Vector3 turn;

    public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.zero;
        turn = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            turn += transform.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            turn -= transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            turn -= transform.up;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turn += transform.up;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            turn += transform.forward;
        }
        if (Input.GetKey(KeyCode.E))
        {
            turn -= transform.forward;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move = transform.forward;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            move -= transform.forward;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = transform.position + (transform.forward * 2);
            var rot = transform.rotation;
            Instantiate(projectile, pos, rot);
        }

    }

    private void FixedUpdate()
    {
        rb.AddTorque(turn * 1.0f);
        rb.AddForce(move * 25.0f);
        
    }
}
