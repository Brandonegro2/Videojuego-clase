using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemigo")   
        {
            {
                GameManager.Instancia.SumaPuntos(1);
               
            }
        }
    }
}