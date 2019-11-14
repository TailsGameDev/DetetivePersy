using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaCanvas : MonoBehaviour
{
    public Canvas Cnvs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Time.timeScale = 0;
            Cnvs.enabled = true;
        }
    }
}
