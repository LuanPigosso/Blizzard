using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public UnityEngine.UI.Text points;
	public UnityEngine.UI.Text records;
	// Update is called once per frame
	
	void Start(){
		points.text = Colisor.qtpontos;
		records.text = Colisor.record;

	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("MenuIniciar");
		}
	
	}
}
