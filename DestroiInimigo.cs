using UnityEngine;
using System.Collections;

public class DestroiInimigo : MonoBehaviour {
	public ParticleSystem efeito;

	void OnCollisionEnter(Collision info){
		Instantiate (efeito, transform.position,Quaternion.Euler(-90,0,0));
		efeito.Play ();
		Destroy (this.gameObject.transform.parent.gameObject);
	}
}
