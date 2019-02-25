using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Placar : MonoBehaviour {

	public Text placar;
	int pontos = 0;

	public void incrementaPlacar () {
		pontos++;
		placar.text = "Pontos = " + pontos.ToString();
	}
}
