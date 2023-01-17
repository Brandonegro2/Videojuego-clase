using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigo : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    [SerializeField] float velocidad = 3, limiteVelocidad = 20;
    [SerializeField] ControladorPersonaje controladorPersonaje;
    public bool playerDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);

        if (transform.position.x < posicionMinima.x && velocidad < limiteVelocidad)
        {
            transform.position = posicionInicial;
            velocidad += 1;
        }
        if (transform.position.x < posicionMinima.x && velocidad == limiteVelocidad)
        {
            transform.position = posicionInicial;
        }
    }

    public void IniciarEnemigo()
    {
        transform.position = posicionInicial;
        velocidad = 3;
    }
}
