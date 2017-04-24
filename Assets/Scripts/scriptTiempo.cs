using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class scriptTiempo : MonoBehaviour
{


    public float fTiempo = 60.0f;   // Tiempo inicial del timer
    public Text tTextoTiempo;           // Texto de tiempo
    float fTiempoRestar = 0.0f;
    public GameObject btnBoton;
    public Slider sliderIzq;
    public Slider sliderDer;
    int valor = 60;

    void Update()
    {
        fTiempo -= fTiempoRestar;
        tTextoTiempo.text = fTiempo.ToString("F0") + "\n segundos";
        determinarAumento();

        // El tiempo se acabo
        if (fTiempo <= 0.0f)
        {
            // Se cambia la escena (todavia le faltan cosas dentro del if)
            SceneManager.LoadScene("escena_PantallaInicio");
        }
    }

    void determinarAumento()
    {

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
    }
    public void comenzarJuego()
    {
        fTiempoRestar = Time.deltaTime;
        Destroy(btnBoton);
    }
}

