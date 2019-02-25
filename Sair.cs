using UnityEngine;
using System.Collections;

public class Sair : MonoBehaviour {


	void Update () {
		if(Input.GetKey("escape")){
			Application.Quit ();
		}
	}
}
