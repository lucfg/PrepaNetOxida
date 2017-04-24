using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptAlimentosSeleccionados : MonoBehaviour {

	public string sAceiteSelec = "";
	public string sComidaSelec = "";

	public string sBtnAceiteSelec = "";
	public string sBtnComidaSelec = "";

	public float fTempMax = 0f;

	void Awake () {
		DontDestroyOnLoad (this);
	}
}
