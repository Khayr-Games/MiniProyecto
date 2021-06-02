using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripTelon : MonoBehaviour
{
    private Animator anim;
    public GameObject colisionadorTelon;
    private AudioSource sonido;


    private GameObject contador;
    private contadir contador_;


    //Variables cambio escenario
    private bool generadorCambios = false;



    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        sonido = gameObject.GetComponent<AudioSource>();
        contador = GameObject.FindGameObjectWithTag("contador");
        contador_ = contador.GetComponent<contadir>();
    }

    // Update is called once per frame
    void Update()
    {
        //TRIGGER CAMBIOS ESCENARIO ENEMIGO
        if (generadorCambios)
        {
            generadorCambios = false;
            Invoke("enemigoCortinaVariables", 3f);
        }
    }


    //CAMBIOS DE VARIABLES Y TIEMPO DE DELAY ALEATORIO
    private void enemigoCortinaVariables()
    {
        float segundos = (Random.Range(1.0f, 4f));
        Invoke("enemigoCortinaActivar", segundos);
    }

    //CAMBIO DE ANIMACION
    private void enemigoCortinaActivar()
    {
        anim.SetBool("escenarioAbierto", true);
        colisionadorTelon.SetActive(true);
        sonido.PlayDelayed(0.4f);
    }

    public void enemigoCortinaDesactivar()
    {
        anim.SetBool("escenarioAbierto", false);
        colisionadorTelon.SetActive(false);
        generadorCambios = true;
        contador_.setContador();
    }
}
