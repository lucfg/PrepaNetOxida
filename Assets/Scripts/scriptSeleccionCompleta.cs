using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptSeleccionCompleta : MonoBehaviour {

	public GameObject DatosEstaticos;
	public scriptAlimentosSeleccionados Script;

	string sAceite = "";
	string sComida = "";

	string sBtnAceite = "";
	string sBtnComida = "";

	void Awake () {
		DatosEstaticos = GameObject.FindGameObjectWithTag ("Datos") as GameObject;
		Script = DatosEstaticos.GetComponent<scriptAlimentosSeleccionados> ();
	}

	public void estaListo () {
		sBtnAceite = Script.sBtnAceiteSelec;
		sBtnComida = Script.sBtnComidaSelec;

		if (sBtnAceite != "" && sBtnComida != "") {

			// Switch para determinar que aceite guardar
			switch (sBtnAceite) {
			case "btnAceiteOliva":
				Script.sAceiteSelec = "Aceite de Oliva";
				Script.fTempMax = 210f;
				break;
			case "btnAceiteSoja":
				Script.sAceiteSelec = "Aceite de Soja";
				Script.fTempMax = 170f;
				break;
			case "btnAceiteMaiz":
				Script.sAceiteSelec = "Aceite de Maiz";
				Script.fTempMax = 160f;
				break;
			case "btnMargarina":
				Script.sAceiteSelec = "Margarina";
				Script.fTempMax = 150f;
				break;
			case "btnMantequilla":
				Script.sAceiteSelec = "Mantequilla";
				Script.fTempMax = 110f;
				break;
			}

			// Switch para determinar que comida guardar
			switch (sBtnComida) {
			case "btnRes":
				Script.sComidaSelec = "Carne de Res";
				break;
			case "btnPollo":
				Script.sComidaSelec = "Pollo";
				break;
			case "btnPescado":
				Script.sComidaSelec = "Pescado";
				break;
			case "btnHuevos":
				Script.sComidaSelec = "Huevos";
				break;
			}
		}

		SceneManager.LoadScene ("escena_PantallaNivel1");
	}
}
