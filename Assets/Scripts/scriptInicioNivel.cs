using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptInicioNivel : MonoBehaviour {

	public GameObject DatosEstaticos;
	public scriptAlimentosSeleccionados Script;

	public string sAceite = "";
	public string sComida = "";
	public Image imgAceite;
	public Image imgComida;

	public Sprite sptAceite1;
	public Sprite sptAceite2;
	public Sprite sptAceite3;
	public Sprite sptAceite4;
	public Sprite sptAceite5;

	public Sprite sptComida1;
	public Sprite sptComida2;
	public Sprite sptComida3;
	public Sprite sptComida4;

	public GameObject goComida1;
	public GameObject goComida2;

	void Awake () {
		DatosEstaticos = GameObject.FindGameObjectWithTag ("Datos") as GameObject;
		Script = DatosEstaticos.GetComponent<scriptAlimentosSeleccionados> ();
	}

	void Start () {
		sAceite = Script.sBtnAceiteSelec;
		sComida = Script.sBtnComidaSelec;

		// Switch para determinar que aceite guardar
		switch (sAceite) {
		case "btnAceiteOliva":
			imgAceite.GetComponent<Image> ().sprite = sptAceite1;
			break;
		case "btnAceiteSoja":
			imgAceite.GetComponent<Image> ().sprite = sptAceite2;
			break;
		case "btnAceiteMaiz":
			imgAceite.GetComponent<Image> ().sprite = sptAceite3;
			break;
		case "btnMargarina":
			imgAceite.GetComponent<Image> ().sprite = sptAceite4;
			break;
		case "btnMantequilla":
			imgAceite.GetComponent<Image> ().sprite = sptAceite5;
			break;
		}

		// Switch para determinar que comida guardar
		switch (sComida) {
		case "btnRes":
			imgComida.GetComponent<Image> ().sprite = sptComida1;
			goComida1.GetComponent<Image> ().sprite = sptComida1;
			goComida2.GetComponent<Image> ().sprite = sptComida1;
			break;
		case "btnPollo":
			imgComida.GetComponent<Image> ().sprite = sptComida2;
			goComida1.GetComponent<Image> ().sprite = sptComida2;
			goComida2.GetComponent<Image> ().sprite = sptComida2;
			break;
		case "btnPescado":
			imgComida.GetComponent<Image> ().sprite = sptComida3;
			goComida1.GetComponent<Image> ().sprite = sptComida3;
			goComida2.GetComponent<Image> ().sprite = sptComida3;
			break;
		case "btnHuevos":
			imgComida.GetComponent<Image> ().sprite = sptComida4;
			goComida1.GetComponent<Image> ().sprite = sptComida4;
			goComida2.GetComponent<Image> ().sprite = sptComida4;
			break;
		}
	}
}
