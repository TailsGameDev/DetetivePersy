using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCliked : MonoBehaviour
{
    public string Descriçao = "Descriçao do objeto";
    public GameObject cnvas;

    private void OnMouseDown()
    {
        cnvas.SetActive(true);
        cnvas.SendMessage("Escreve",Descriçao);
        this.gameObject.SetActive(false);
    }

    
    
}
