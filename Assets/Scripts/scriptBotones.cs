using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptBotones : MonoBehaviour {

	public Toggle tggAceite;

	public Toggle tggAceite1;
	public Toggle tggAceite2;
	public Toggle tggAceite3;
	public Toggle tggAceite4;

	string sAceite = "";
	string sBtnAceite = "";

	public GameObject DatosEstaticos;
	public scriptAlimentosSeleccionados Script;

	void Awake () {
		DatosEstaticos = GameObject.FindGameObjectWithTag ("Datos") as GameObject;
		Script = DatosEstaticos.GetComponent<scriptAlimentosSeleccionados> ();
	}

	public void estaOprimido () {
		if (tggAceite.isOn) {
			GetComponent<Image> ().color = Color.yellow;
			sBtnAceite = tggAceite.name;

			tggAceite1.interactable = false;
			tggAceite2.interactable = false;
			tggAceite3.interactable = false;
			tggAceite4.interactable = false;

			Script.sBtnAceiteSelec = sBtnAceite;
		} else {
			GetComponent<Image> ().color = Color.white;
			sBtnAceite = "";

			tggAceite1.interactable = true;
			tggAceite2.interactable = true;
			tggAceite3.interactable = true;
			tggAceite4.interactable = true;

			Script.sBtnAceiteSelec = "";
		}
	}
}
