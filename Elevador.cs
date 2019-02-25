using UnityEngine;
using System.Collections;

public class Elevador : MonoBehaviour {

	public float pontoA;
	public float pontoB;
	public float vel;
	int movimento = 1;

	void Start(){
		Vector3 inicial = new Vector3 (transform.position.x, pontoA, transform.position.z);
		transform.position = inicial;
	}

	void FixedUpdate () {
		if(transform.position.y <= pontoA){
			movimento = 1;
			//transform.Translate (0, 1 * vel * Time.deltaTime, 0);
		}
		if (transform.position.y >= pontoB) {
			movimento = -1;
			//transform.Translate (0, -1 * vel * Time.deltaTime, 0);
		}

		transform.Translate (0, movimento * vel * Time.fixedDeltaTime, 0, Space.World);
	
	}

	void OnCollisionEnter(Collision info){
		if (info.gameObject.tag == "Player") {
			//player vira filho do elevador
			info.gameObject.transform.parent = this.gameObject.transform;
		}
	}

	void OnCollisionExit(Collision info){
		if (info.gameObject.tag == "Player") {
			//player deixa de ser filho do elevador
			info.gameObject.transform.parent = null;
		}
	}
}
