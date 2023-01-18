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
    [SerializeField] GameObject textoGameOver, botonGameOver, jugador, enemigo;
    [SerializeField] bool cronometro = true;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sonidos;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        
        mejorPuntuacion = PlayerPrefs.GetInt("MejorPuntuacion");
    }

    void Start()
    {
        textoGameOver.SetActive(false);
        botonGameOver.SetActive(false);
    }

    void Update()
    {
        if (cronometro)
        {
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            // textoTiempo.text = minutos + ":" + segundos;
            textoTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }   
    }

   
    public void SumaPuntos(int puntos)
    {
        puntuacionActual += puntos;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", mejorPuntuacion);
        }
    }
    public void Perder()
    {
        audioSource.clip = sonidos[0];
        audioSource.Play();
        jugador.SetActive(false);
        enemigo.SetActive(false);
        textoGameOver.SetActive(true);
        botonGameOver.SetActive(true);
        cronometro = false;
    }
    

    public void Reiniciar()
    {
        enemigo.GetComponent<MoverEnemigo>().IniciarEnemigo();
        puntuacionActual = 0;
        tiempo = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        textoGameOver.SetActive(false);
        botonGameOver.SetActive(false);
        cronometro = true;      
    }
}