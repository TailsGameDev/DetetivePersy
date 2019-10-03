using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UI;

public class onCliked : MonoBehaviour
{
    bool japrintado = false;
    public string Descriçao = "Descriçao do objeto";
    public GameObject cnvas;
    public Text Bloco;
    private void OnMouseDown()
    {
        //ObjDados.SetDados(Descriçao,Img);
        cnvas.SetActive(true);
        cnvas.SendMessage("Escreve",Descriçao);
        if (japrintado == false)
        { 
            Bloco.text = Bloco.text + "\n" + Descriçao;
        }
        this.gameObject.SetActive(false);
        japrintado = true;
    }

}

