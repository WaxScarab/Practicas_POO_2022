using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Plano o Blueprint
public class JugadorBase : MonoBehaviour
{
    //Atributos
    public int vida;
    public float jumpForce;
    public float velocidad;
    
    //Comportamientos
    public void Daño(int cantidadDaño){
        vida -= cantidadDaño;
    }
    
    
    public void Saltar(){
        
    }
    
    public void Correr(){
        
    }
    
}
