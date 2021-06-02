using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoMafioso : MonoBehaviour
{
    public Transform transformador;
    public Animator anim;
    public GameObject colisionadorMafioso;
    private Rigidbody2D rb;
    private AudioSource sonido;

    //Variables cambio escenario
    private bool generadorCambios = false;
    private Vector2 vector;

    private GameObject contador;
    private contadir contador_;


    void Start()
    {
        transformador = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
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
            Invoke("mafiosoVariable", 3f);
        }
    }


    //CAMBIOS DE VARIABLES Y TIEMPO DE DELAY ALEATORIO
    private void mafiosoVariable()
    {
        float segundos = (Random.Range(1.0f, 4f));
        Invoke("mafiosoMoverArriba", segundos);
    }

    //CAMBIO DE ANIMACION
    private void mafiosoMoverArriba()
    {
        colisionadorMafioso.SetActive(true);
        anim.SetBool("salir", true);
        sonido.PlayDelayed(0.4f);
    }

    public void mafiosoMoverAbajo()
    {
        Debug.Log("mafiosoabajo");
        anim.SetBool("salir", false);
        colisionadorMafioso.SetActive(false);
        generadorCambios = true;
        contador_.setContador();
    }
}
