using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigo2 : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    [SerializeField] float velocidad = 5;
    [SerializeField] ControladorPersonaje controladorPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
        StartCoroutine(Reaparecer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);

        if (transform.position.x < posicionMinima.x)
        {
            Reaparecer();
            transform.position = posicionInicial;  
        }
    }

    IEnumerator Reaparecer()
    {
        yield return new WaitForSeconds(5);
    }

    public void IniciarEnemigo2()
    {
        transform.position = posicionInicial;
    }
}