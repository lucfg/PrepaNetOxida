using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptFinalNivel : MonoBehaviour {

    string[] ganaOpierde;
   
    public GameObject DatosEstaticos;
    public GameObject Dato;
    public scriptAlimentosSeleccionados Script;
    public scrptGanoPerdio script2;

    public string sAceite = "";
    public string sComida = "";

    //imagenes y Texto
    public Image imgAceite;
    public Image imgComida;
    public Text texto;

    //compuestos buenos
    public Sprite compuesto1;
    public Sprite compuesto2;
    public Sprite compuesto3;
    public Sprite compuesto4;
    public Sprite compuesto5;

    //platillos buenos
    public Sprite platillo1;
    public Sprite platillo2;
    public Sprite platillo3;
    public Sprite platillo4;

    //compuestos malos
    public Sprite descompuesto1;
    
    //platillos malos
    public Sprite platilloMalo1;

    void Awake()
    {
        DatosEstaticos = GameObject.FindGameObjectWithTag("Datos") as GameObject;
        Dato = GameObject.FindGameObjectWithTag("Datos2") as GameObject;
        Script = DatosEstaticos.GetComponent<scriptAlimentosSeleccionados>();
        script2 = Dato.GetComponent<scrptGanoPerdio>();
    }

    // Use this for initialization
    void Start() {
        ganaOpierde = new string [2] { "¡Perfecto! \n ¡¡Realizaste el cocimiento perfecto de tu cena!! \n"+
                                        "Lograste retener todos los nutrientes esenciales del aceite \n"+
                                        "y maximizaste el valor nutrimental. Ahora podrás disfrutar \n" +
                                        "de una comida excelente llena de energía y sin sentirte culpable.\n" +
                                        "¡Enhorabuena!\n"+
                                        "Las moléculas del aceite permanecieron en su forma original \n" +
                                        "y natural al ser cocidas a una temperatura menor a su punto \n"+
                                        "de fusión y evitando la creación de un radical libre.",

                                        "¡Oh no, creaste un radical libre!\n"+
                                        "Al no controla la temperatura correctamente sobrepasaste el punto \n"+
                                        "de fusión y liberaste un hidrocarburo que cambio la estructura \n"+
                                        "del aceite. Ahora tu aceite tiene un color obscuro, sabor rancio \n"+
                                        "y se generaron ácidos grasos trans muy dañinos para tu salud." };


	    sAceite = Script.sBtnAceiteSelec;
        sComida = Script.sBtnComidaSelec;

        if (script2.gano)
        {
            texto.text = ganaOpierde[0];
        }
        else
        {
            texto.text = ganaOpierde[1];
        }

        switch (sAceite)
        {
            case "btnAceiteOliva":
                if (script2.gano){
                    imgAceite.GetComponent<Image>().sprite = compuesto1;
                }
                else{
                    imgAceite.GetComponent<Image>().sprite = descompuesto1;
                }
                break;
            case "btnAceiteSoja":
                if (script2.gano)
                {
                    imgAceite.GetComponent<Image>().sprite = compuesto2;
                }
                else
                {
                    imgAceite.GetComponent<Image>().sprite = descompuesto1;
                }
                break;
            case "btnAceiteMaiz":
                if (script2.gano)
                {
                    imgAceite.GetComponent<Image>().sprite = compuesto3;
                }
                else
                {
                    imgAceite.GetComponent<Image>().sprite = descompuesto1;
                }
                break;
            case "btnMargarina":
                if (script2.gano)
                {
                    imgAceite.GetComponent<Image>().sprite = compuesto1;
                }
                else
                {
                    imgAceite.GetComponent<Image>().sprite = descompuesto1;
                }
                break;
            case "btnMantequilla":
                if (script2.gano)
                {
                    imgAceite.GetComponent<Image>().sprite = compuesto1;
                }
                else
                {
                    imgAceite.GetComponent<Image>().sprite = descompuesto1;
                }
                break;
        }

        switch (sComida)
        {
            case "btnRes":
                if (script2.gano)
                {
                    imgComida.GetComponent<Image>().sprite = platillo1;
                }
                else
                {
                    imgComida.GetComponent<Image>().sprite = platilloMalo1;
                }

                break;
            case "btnPollo":
                if (script2.gano)
                {
                    imgComida.GetComponent<Image>().sprite = platillo2;
                }
                else
                {
                    imgComida.GetComponent<Image>().sprite = platilloMalo1;
                }
                break;
            case "btnPescado":
                if (script2.gano)
                {
                    imgComida.GetComponent<Image>().sprite = platillo3;
                }
                else
                {
                    imgComida.GetComponent<Image>().sprite = platilloMalo1;
                }
                break;
            case "btnHuevos":
                if (script2.gano)
                {
                    imgComida.GetComponent<Image>().sprite = platillo4;
                }
                else
                {
                    imgComida.GetComponent<Image>().sprite = platilloMalo1;
                }
                break;
        }

    }
}
