using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleBOtao : MonoBehaviour
{
    public Canvas Pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.enabled = true;
            Time.timeScale = 0f;
        }
        
    }

    //Cara pra q pausar se qd tu nao faz nada o jogo fica parado? (Caina)
    public void Reume() {
        Pause.enabled = false;
        Time.timeScale = 1;

    }
    public void Sair() {
        Time.timeScale = 1f;
      //carregar menu principal  SceneManager.LoadScene("Cena01");
        Pause.enabled = false;
    }

}
