using UnityEngine;
using System.Collections;

public class Rotacionar : MonoBehaviour {

	public float velocidadeRotate = 125.0f;

	void Update () {
	
		transform.Rotate (0, velocidadeRotate * Time.deltaTime, 0);

	}
}
