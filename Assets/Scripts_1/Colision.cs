using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public string etiqueta;
    public int daño;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == etiqueta)
        {
            collision.gameObject.GetComponent<ControlVida>().restarVida(daño);
        }      
    }
}
