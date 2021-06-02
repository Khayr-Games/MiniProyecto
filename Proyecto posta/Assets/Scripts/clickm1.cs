using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickm1 : MonoBehaviour
{
    public GameObject objetoEncontrar2;
    string mafioso1 = "mafioso1";
    public movimientoMafioso mafioso1_;
    // Start is called before the first frame update
    void Start()
    {
        objetoEncontrar2 = GameObject.FindGameObjectWithTag(mafioso1);
        mafioso1_ = objetoEncontrar2.GetComponent<movimientoMafioso>();
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
            mafioso1_.mafiosoMoverAbajo();
        }
    }
}