using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVida : MonoBehaviour
{
    
    JugadorBase vidaPlayer;
    
    public int daño;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaPlayer=GetComponentInParent<JugadorBase>();
    }

    
    
    public void restarVida(int daño){
        
        vidaPlayer.vida -= daño;
    }

    public void sumarVida(int vida) {

        vidaPlayer.vida += vida;
    }
}
