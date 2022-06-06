using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPlayer : MonoBehaviour
{
    public TextMeshProUGUI nombreTextM;
    public TextMeshProUGUI vidaTextM;
    //public Text vidaText;
    //public Text nombreText;
    
    private JugadorBase datos;
    // Start is called before the first frame update
    void Start()
    {
        datos = GetComponent<JugadorBase>();
       
       nombreTextM.text = datos.name;
       
       vidaTextM.text= "Vida: " + datos.vida;
    }

    // Update is called once per frame
    void Update()
    {
         nombreTextM.text = datos.name;
       
       vidaTextM.text= "Vida: " + datos.vida;
    }
}
