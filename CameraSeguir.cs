using UnityEngine;
using System.Collections;

public class CameraSeguir : MonoBehaviour {

	public GameObject player;
	public Vector3 distancia;

	void Update () {
		if (player != null) {
			transform.position = player.transform.position + distancia;
		}
	}
}
 