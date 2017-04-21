using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string destino;

	public void CargaEscena() {
		SceneManager.LoadScene(destino);
	}
}