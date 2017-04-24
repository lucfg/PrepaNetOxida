using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptBotonesComida : MonoBehaviour {

	public Toggle tggComida;

	public Toggle tggComida1;
	public Toggle tggComida2;
	public Toggle tggComida3;

	string sComida = "";
	string sBtnComida = "";

	public GameObject DatosEstaticos;
	public scriptAlimentosSeleccionados Script;

	void Awake () {
		DatosEstaticos = GameObject.FindGameObjectWithTag ("Datos") as GameObject;
		Script = DatosEstaticos.GetComponent<scriptAlimentosSeleccionados> ();
	}

	public void estaOprimido () {
		if (tggComida.isOn) {
			GetComponent<Image> ().color = Color.yellow;
			sBtnComida = tggComida.name;

			tggComida1.interactable = false;
			tggComida2.interactable = false;
			tggComida3.interactable = false;

			Script.sBtnComidaSelec = sBtnComida;
		} else {
			GetComponent<Image> ().color = Color.white;
			sBtnComida = "";

			tggComida1.interactable = true;
			tggComida2.interactable = true;
			tggComida3.interactable = true;

			Script.sBtnComidaSelec = "";
		}
	}
}
