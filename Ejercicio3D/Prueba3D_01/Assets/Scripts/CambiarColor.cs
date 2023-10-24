using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objeto"))
        {
            Renderer sphereRenderer = collision.gameObject.GetComponent<Renderer>();
            sphereRenderer.material.color = UnityEngine.Color.black;
        }
    }
}
