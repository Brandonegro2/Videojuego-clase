using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sonidos;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemigo")   
        {
            {
                audioSource.clip = sonidos[0];
                audioSource.Play();
                GameManager.Instancia.SumaPuntos(1);
            }
        }
    }
}