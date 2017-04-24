using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class scriptTiempo : MonoBehaviour
{

    public float fTiempo = 30.0f;   // Tiempo inicial del timer
    public Text tTextoTiempo;           // Texto de tiempo
    float fTiempoRestar = 0.0f;
    public GameObject btnBoton;
    public Slider sliderIzq;
    public Slider sliderDer;
    int valor = 30;
    public RectTransform panel;
    public Text tempMaxima;
    public Text textoFinal;

    public GameObject DatosEstaticos;
    public scrptGanoPerdio Script;

    void Awake()
    {
        DatosEstaticos = GameObject.FindGameObjectWithTag("Datos2") as GameObject;
        Script = DatosEstaticos.GetComponent<scrptGanoPerdio>();
    }

    void Update()
    {
        fTiempo -= fTiempoRestar;
        
        // El tiempo se acabo
        if (fTiempo <= 0.0f ){
         
            panel.gameObject.SetActive(true);

        }else {
            tTextoTiempo.text = fTiempo.ToString("F0") + "\n segundos";
            determinarAumento();
        }
    }

    void determinarAumento(){
        int valorActual = Int32.Parse(tTextoTiempo.text.ToString().Substring(0, 2));

        if (valorActual == valor - 1)
        {
            incrementarSlider();
            valor--;
        }
    }

    void incrementarSlider()
    {
        int tiempo = Int32.Parse(tTextoTiempo.text.ToString().Substring(0, 2));
        int temperaturaIzq = (int)sliderIzq.value;
        int temperaturaDer = (int)sliderDer.value;

        if (tiempo >= 45)
        {
            //Aumenta de 15 en 15
            sliderIzq.value = temperaturaIzq + 15;
            sliderDer.value = temperaturaDer + 15;

        }
        else if (tiempo < 45 && tiempo >= 30)
        {
            //Aumenta de 20 en 20
            sliderIzq.value = temperaturaIzq + 20;
            sliderDer.value = temperaturaDer + 20;

        }
        else if (tiempo < 30 && tiempo >= 15)
        {
            //Aumenta de 25 en 25
            sliderIzq.value = temperaturaIzq + 25;
            sliderDer.value = temperaturaDer + 25;

        }
        else if (tiempo < 15)
        {
            //Aumenta de 45 en 45
            sliderIzq.value = temperaturaIzq + 40;
            sliderDer.value = temperaturaDer + 40;

        }


        if (temperaturaIzq >= Int32.Parse(tempMaxima.text.ToString()) || temperaturaDer >= Int32.Parse(tempMaxima.text.ToString()))
        {
            fTiempo = 0.0f;
            panel.gameObject.SetActive(true);
            textoFinal.text = "¡Haz excedido la \n temperatura permitida!";
            Script.gano = false;
        }
    }
    public void comenzarJuego()
    {
        fTiempoRestar = Time.deltaTime;
        Destroy(btnBoton);
    }

    public void finalizarJuego()
    {
        SceneManager.LoadScene("escena_Ganar");
    }

    public void change() {
        int temperaturaIzq = (int)sliderIzq.value;
        int temperaturaDer = (int)sliderDer.value;

        if (temperaturaIzq >= Int32.Parse(tempMaxima.text.ToString()) || temperaturaDer >= Int32.Parse(tempMaxima.text.ToString()))
        {
            fTiempo = 0.0f;
            panel.gameObject.SetActive(true);
            textoFinal.text = "¡Haz excedido la \n temperatura permitida!";
            Script.gano = false;
        }
    }
}

