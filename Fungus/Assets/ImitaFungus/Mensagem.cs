using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensagem : MonoBehaviour
{

    public GameObject objetoParaAtivar;

    public void OnMouseDown () {
        objetoParaAtivar.SetActive(true);
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
