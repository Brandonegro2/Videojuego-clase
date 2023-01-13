using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public float tiempo = 0;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] public int mejorPuntuacion, puntuacionActual;
    public static GameManager Instancia;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
            mejorPuntuacion = PlayerPrefs.GetInt("MejorPuntuacion");
    }
    void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        // textoTiempo.text = minutos + ":" + segundos;
        textoTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void ActualizarPuntuacion(int puntos)
    {
        puntuacionActual += puntos;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", mejorPuntuacion);
        }
    }
    public void SumaPuntos(int puntos)
    {
        puntuacionActual += puntos;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
    public void Perder()
    {

    }
    

    public void Reiniciar()
    {

    }
}