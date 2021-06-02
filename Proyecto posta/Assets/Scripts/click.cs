using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject objetoEncontrar1;
    string mafiosa = "telon";
    public scripTelon telon;
    // Start is called before the first frame update
    void Start()
    {
        objetoEncontrar1 = GameObject.FindGameObjectWithTag(mafiosa);
        telon = objetoEncontrar1.GetComponent<scripTelon>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  void OnMouseOver()
        {
                if (Input.GetMouseButtonDown(0))
                {
                    telon.enemigoCortinaDesactivar();
                }
                }
            }
       
