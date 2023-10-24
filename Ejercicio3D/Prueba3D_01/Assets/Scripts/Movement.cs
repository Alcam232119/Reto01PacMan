using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; //Va con f al final porque es Float
    public float speedRotation = 10f;
    void Start()
    {
        
    }

    
    void Update() //Acá se ejecutan funciones de movimiento
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //Si no se especifica el tipo de la variable, 
        //automaticamente quedá como Privada.
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        Vector3 move = new Vector3(horizontalInput, jumpInput, verticalInput);
        move.Normalize(); 
        transform.position = transform.position + move * speed * Time.deltaTime;

        if (move != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), speedRotation * Time.deltaTime);

        }

    }
}
