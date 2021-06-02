using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickm2 : MonoBehaviour
{
    
    public GameObject objetoEncontrar3;
    string mafioso2 = "mafioso2";
    public movimientoMafioso2 mafioso2_;
    // Start is called before the first frame update
    void Start()
    {
        objetoEncontrar3 = GameObject.FindGameObjectWithTag(mafioso2);
        mafioso2_ = objetoEncontrar3.GetComponent<movimientoMafioso2>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click2");
            mafioso2_.mafiosoMoverAbajo();
        }
    }
}
