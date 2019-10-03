using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoDoBloco : MonoBehaviour
{
    public static string textoDoBloco = "";

    void Start()
    {
        GetComponent<Text>().text = textoDoBloco;
    }

}
