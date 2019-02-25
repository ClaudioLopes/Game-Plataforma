using UnityEngine;
using System.Collections;

public class InimigoMoviment : MonoBehaviour {

	public float pontoA;
	public float pontoB;
	public float vel;
	int movimento = 1;

	void Start(){
		Vector3 inicial = new Vector3 (transform.position.x, transform.position.y, pontoA);
		transform.position = inicial;
	}

	void FixedUpdate () {
		if(transform.position.z <= pontoA){
			movimento = 1;
		}
		if (transform.position.z >= pontoB) {
			movimento = -1;	
		}

		transform.Translate (0, 0, movimento * vel * Time.fixedDeltaTime);

	}
}
