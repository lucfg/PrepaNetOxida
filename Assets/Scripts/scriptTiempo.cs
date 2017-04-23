using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptTiempo : MonoBehaviour {

	public float fTiempo = 60.0f;	// Tiempo inicial del timer
	public Text tTextoTiempo;			// Texto de tiempo

	void Update () {
		fTiempo -= Time.deltaTime;
		tTextoTiempo.text = fTiempo.ToString("F0") + "\n segundos";

		// El tiempo se acabo
		if (fTiempo <= 0.0f) {
			// Se cambia la escena (todavia le faltan cosas dentro del if)
			SceneManager.LoadScene ("escena_PantallaInicio");
		}
	}
}
