using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class miraMouse : MonoBehaviour
{
    public Transform mira;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Que la mira siga al mouse
        mira.position = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            1f
            ));
    }

   
}
