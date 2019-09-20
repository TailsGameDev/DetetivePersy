using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class onCliked : MonoBehaviour
{
    public string Descriçao = "Descriçao do objeto";
    public GameObject cnvas;
    public Sprite Img;
    DadosCanvas ObjDados = new DadosCanvas();
    private void OnMouseDown()
    {
        ObjDados.SetDados(Descriçao,Img);
        cnvas.SetActive(true);
        cnvas.SendMessage("Escreve", ObjDados);

    }
}
//classe para enviar os dados para o canvas
public class DadosCanvas
{
    public  string Descricao;
    public Sprite Img;

    public void SetDados (string Desc,Sprite ImagemProva) {
        this.Descricao = Desc;
        this.Img = ImagemProva;

    }

}

