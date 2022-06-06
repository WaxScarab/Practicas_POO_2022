using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEnemy : MonoBehaviour
{
    public TextMeshProUGUI vidaText;
    public TextMeshProUGUI tipoText;
    
    private Enemy datos;
    // Start is called before the first frame update
    void Start()
    {
        datos = GetComponent<Enemy>();
       
      // vidaText.text = datos.name;
       
       //tipoText.text= "Vida: " + datos.vida;
    }

    // Update is called once per frame
    void Update()
    {
        // vidaText.text = datos.name;
       
       //tipoText.text= "Vida: " + datos.vida;
    }
}
