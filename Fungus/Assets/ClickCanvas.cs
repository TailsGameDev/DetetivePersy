using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCanvas : MonoBehaviour
{
    public GameObject prova;
    public GameObject cnvas;
    public Text texto;

    private void OnMouseDown()
    {
        prova.SetActive(true);
        cnvas.SetActive(false);
    }


    void Update()
    {
        
    }
    public void Botao() {
        prova.SetActive(true);
        cnvas.SetActive(false);
        

    }
    public void Escreve(string texto) {
        this.texto.text = texto;

    }
}
