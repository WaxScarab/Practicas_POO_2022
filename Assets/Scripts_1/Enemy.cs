using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Enemy 
{
    public int vida;
    public string tipo;
    public float velocidad;

    public Enemy (int v, string tipo, float velocidad)
    {
        this.vida = v;
        this.tipo = tipo;
        this.velocidad = velocidad;
    }   

    public void Ataque()
    {

    }

    public void Movimiento()
    {

    }


    
}
