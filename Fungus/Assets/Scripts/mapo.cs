using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapo : MonoBehaviour
{
    public Scene duro;
    // Start is called before the first frame update

    public void OnMouseDown()
    {
        //  SceneManager.LoadScene(duro.name);
        print("hahala");
        Debug.Log("Entra cena 01");
    }
}
