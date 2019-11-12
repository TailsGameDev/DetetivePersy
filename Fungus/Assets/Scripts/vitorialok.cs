using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vitorialok : MonoBehaviour
{
    public Transform roda1;
    public Transform roda2;
    public Transform roda3;
    public bool certo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roda1.transform.localEulerAngles.z == (roda2.transform.localEulerAngles.z + 120) && roda2.transform.localEulerAngles.z == (roda3.transform.localEulerAngles.z + 120))
        {
            win();
            certo = true;
        }
    }
    void win()
    {
        print("Você ganhou!!!");
        //futuramente utilizar esse void
    }
}
