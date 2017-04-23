using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptBotonesComida : MonoBehaviour {

	public Toggle tggComida;

	public Toggle tggComida1;
	public Toggle tggComida2;
	public Toggle tggComida3;

	public void estaOprimido () {
		if (tggComida.isOn) {
			GetComponent<Image> ().color = Color.yellow;

			tggComida1.interactable = false;
			tggComida2.interactable = false;
			tggComida3.interactable = false;
		} else {
			GetComponent<Image> ().color = Color.white;

			tggComida1.interactable = true;
			tggComida2.interactable = true;
			tggComida3.interactable = true;
		}
	}
}
