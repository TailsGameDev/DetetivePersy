using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCanvas : MonoBehaviour
{
   
    public GameObject cnvas;
    public Text texto;
    public Image ImagemProva;
    

    private void OnMouseDown()
    {

        cnvas.SetActive(false);
    }


    void Update()
    {
        
    }
    public void Botao() {
        
        cnvas.SetActive(false);
        

    }
    /*
    public void Escreve(DadosCanvas dados) {

        this.texto.text = dados.Descricao;
        this.ImagemProva.sprite = dados.Img;

    }
    */
}
