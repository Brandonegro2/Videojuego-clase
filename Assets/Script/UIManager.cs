using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text puntuacionActual, mejorPuntuacion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacion.text = GameManager.Instancia.mejorPuntuacion.ToString();
    }
}
