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

	public void estaOprimido () {
		if (tggAceite.isOn) {
			GetComponent<Image> ().color = Color.yellow;

			tggAceite1.interactable = false;
			tggAceite2.interactable = false;
			tggAceite3.interactable = false;
			tggAceite4.interactable = false;
		} else {
			GetComponent<Image> ().color = Color.white;

			tggAceite1.interactable = true;
			tggAceite2.interactable = true;
			tggAceite3.interactable = true;
			tggAceite4.interactable = true;
		}
	}
}
