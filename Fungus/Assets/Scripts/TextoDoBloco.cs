using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoDoBloco : MonoBehaviour
{
    public static string textoDoBloco = "";
    public static List<string> titulos = new List<string>();

    void Start()
    {
        GetComponent<Text>().text = textoDoBloco;
    }

    private void OnEnable () {
        printList(GetAleatorios(5));
    }

    //essa função é mais uma demonstração de como ver se alguma evidencia estah no bloco
    bool ContemNoBloco (string tituloEvidencia) {
        return textoDoBloco.Contains(tituloEvidencia + ':');
    }

    List<string> GetAleatorios (int num) {
        string[] r = new string[num];
 
        List<string>myTitulos = new List<string>(); //criando clone da lista de titulos
        myTitulos.AddRange(titulos);

        Embaralha(myTitulos);

        if (myTitulos.Count < num) num = myTitulos.Count;

        return myTitulos.GetRange(0 , num);
    }

    void Embaralha <T>(List<T> list) { //peguei do Stack Overflow, pesquisando how to shuffle list
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n+1);
            T titulo = list[k];
            list[k] = list[n];
            list[n] = titulo;
        }
    }

    void printList (List<string> list) {
        string r = "";
        for (int i = 0 ; i < list.Count ; i++) {
            r += list[i] + "; ";
        }
        print(r);
    }
}
