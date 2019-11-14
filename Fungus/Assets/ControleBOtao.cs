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
        
    }
    public void Reume() {
        Pause.enabled = false;
        Time.timeScale = 1;

    }
    public void Sair() {

    }
    
}
