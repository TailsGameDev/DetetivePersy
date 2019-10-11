using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CainaCirculo : MonoBehaviour
{
    static readonly List<Color> cores = new List<Color>(){ Color.red, Color.green, Color.blue };
    static List<CainaCirculo> circulos = new List<CainaCirculo>();
    static bool girando = false;

    public Color corCerta;
    public Color corAtual;
    public bool aleatorizar;
    public static float tempoFinal = 1; // quanto tempo demora para girar
    public Text textoPuzzleResolvido;

    private void Awake () {
        circulos.Add(this);
    }

    private void Start () {
        if (aleatorizar) {
            AleatorizaRotacao();
            AleatorizaSolucao();
        }
    }

    //gira instantaneamente
    public void Gira () {
         Gira(transform.eulerAngles);
    }

    public void Gira(Vector3 eulerAnglesInicial) {
        transform.eulerAngles = eulerAnglesInicial + new Vector3(0 , 0 , 120);
        corAtual = cores[(cores.IndexOf(corAtual) + 1) % 3]; // % eh operador que pega o resto de uma divisão.
    }

    public bool PuzzleResolvido () {
        var resolvido = true;
        foreach (CainaCirculo c in circulos) {
            resolvido = resolvido && c.EsseCirculoTahCerto();
        }
        return resolvido;
    }

    public bool EsseCirculoTahCerto () {
        return corCerta == corAtual;
    }

    public void GiraAnimado () {
        if (girando == false) {
            StartCoroutine(AnimaGiro());
        }
    }

    IEnumerator AnimaGiro () {
        girando = true;
            Vector3 eulerAnglesInicial = transform.eulerAngles;

            float zInicial = transform.eulerAngles.z;
            float zFinal = (zInicial + 120);
 
            float vel = (zFinal-zInicial)/tempoFinal;

            float tempoAtual = 0;
            //float zAtual = zInicial;

            while (tempoAtual < tempoFinal) {
                tempoAtual += Time.deltaTime;
                transform.Rotate(new Vector3(0 , 0 , Time.deltaTime*vel));
                yield return null;
            }

            Gira(eulerAnglesInicial); // melhorando precisão e ajustando cores
            if (PuzzleResolvido()) {
                textoPuzzleResolvido.gameObject.SetActive(true);
            }
        girando = false;
    }

    void AleatorizaSolucao () {
        corCerta = cores[Random.Range(0 , 3)];
        while (PuzzleResolvido()) {
            corCerta = cores[Random.Range(0 , 3)];
        }
    }

    void AleatorizaRotacao () {
        int r = Random.Range(0,3);
        while (r > 0) {
            r = r - 1;
            Gira();
        }
        if (PuzzleResolvido()) {
            AleatorizaRotacao();
        }
    }
}
