using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int mejorPuntuacion, puntuacionActual;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemigo")
        {
            GameManager.Instancia.ActualizarPuntuacion(1);
        }
    }
}