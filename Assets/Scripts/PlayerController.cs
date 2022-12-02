using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    public float turnSpeed = 20f;
    public float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar el Imput Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Movimiento hacia adelante
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        // Movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        if (verticalInput > 0)
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
        if (verticalInput < 0)
        {
            transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
}
