using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerColisao : MonoBehaviour {

	public Placar controlador;
	public ParticleSystem efeito;
	public ParticleSystem efeitoVitoria;

	bool temChave = false;

	void OnTriggerEnter(Collider info){

		if(info.gameObject.tag == "moeda"){
			Destroy (info.gameObject);
			controlador.incrementaPlacar ();
		}

		if (info.gameObject.tag == "queda") {
			Instantiate (efeito, transform.position,Quaternion.identity);
			efeito.Play ();
			Destroy (this.gameObject);
			Invoke ("Reset", 1.0f);
		}

		if (info.gameObject.tag  == "Win") {
			Instantiate (efeitoVitoria, transform.position, Quaternion.identity);
			efeitoVitoria.Play ();
			Destroy (this.gameObject);
			Invoke ("NextLevel", 2.0f);
		}

		if (info.gameObject.tag == "inimigo") {
			Instantiate (efeito, transform.position,Quaternion.Euler(-90,0,0));
			efeito.Play ();
			Destroy (this.gameObject);
			Invoke ("Reset", 1.0f);
		}

		if (info.gameObject.tag == "chave") {
			Destroy (info.gameObject);
			temChave = true;
		}

	}

	void OnCollisionEnter(Collision info){
		
		if (info.gameObject.tag == "porta" && temChave) {
			info.gameObject.transform.Rotate (0,0,90);
		}

	}

	void NextLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	void Reset(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}
