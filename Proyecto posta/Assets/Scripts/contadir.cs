using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadir : MonoBehaviour
{
    public Transform refN0, refN1, refN2, refN3, refN4, refN5, refN6, refN7, refN8, refN9;
    int contador = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarContador()
    {
        switch (contador)
        {
            case 1:
                refN1.gameObject.SetActive(true);
                refN0.gameObject.SetActive(false);
                break;
            case 2:
                refN2.gameObject.SetActive(true);
                refN1.gameObject.SetActive(false);
                break;
            case 3:
                refN3.gameObject.SetActive(true);
                refN2.gameObject.SetActive(false);
                break;
            case 4:
                refN4.gameObject.SetActive(true);
                refN3.gameObject.SetActive(false);
                break;
            case 5:
                refN5.gameObject.SetActive(true);
                refN4.gameObject.SetActive(false);
                break;
            case 6:
                refN6.gameObject.SetActive(true);
                refN5.gameObject.SetActive(false);
                break;
            case 7:
                refN7.gameObject.SetActive(true);
                refN6.gameObject.SetActive(false);
                break;
            case 8:
                refN8.gameObject.SetActive(true);
                refN7.gameObject.SetActive(false);
                break;
            case 9:
                refN9.gameObject.SetActive(true);
                refN8.gameObject.SetActive(false);
                break;
        }

        
    }

    public void setContador()
    {
        contador++;
        cambiarContador();
    }
}
