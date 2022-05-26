using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPrincipal : MonoBehaviour
{
    public int salud;
    public float puntos_combate;
    public float velocidad;

  
    public void Lanzallamas(string mensaje)
    {
        Debug.Log(this.gameObject.name + mensaje);
    }
}
