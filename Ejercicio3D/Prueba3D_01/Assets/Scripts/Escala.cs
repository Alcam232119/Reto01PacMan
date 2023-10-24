using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    private bool colisiono = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objeto") && !colisiono)
        {
            Transform sphereTransform = collision.gameObject.transform;
            sphereTransform.localScale *= 0.5f;

            colisiono = true;
        }
    }

}
