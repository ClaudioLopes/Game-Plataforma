using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float velocidade = 0.2f;
	public float pulo = 7.0f;
	Rigidbody body;
	bool noChao = false;
	bool pular = false;

	void Start () {
	
		body = GetComponent <Rigidbody> ();

	}

	void FixedUpdate () {

		body.AddForce (0, 0, velocidade * Input.GetAxisRaw ("Horizontal"),ForceMode.VelocityChange);

		if (pular && noChao) {

			noChao = false;
			body.AddForce (0, pulo, 0, ForceMode.Impulse);

		}
	}

	void Update(){
		pular = false;

		if (Input.GetKeyDown ("space") || Input.GetKeyDown ("w") || Input.GetKeyDown ("up")) {
			pular = true;
		}

	}

	void OnCollisionEnter(Collision info){

		if (info.gameObject.tag == "Chao") {
			noChao = true;
		}
	}
}