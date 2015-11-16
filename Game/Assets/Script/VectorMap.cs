using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
//maps inclinado	
	//lista de pistas totais
	public GameObject[]Maps;
	//lista das pistas instanciadas e atualizadas
	static List <GameObject> atual;
	static public int count;
	static public int size=2500;
	static int num;
	private static int i = 0;
	

	// Use this for initialization
	void Start () {
	   count=0;
		atual = new List<GameObject>();
		//num = Random.Range(0,2);
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position, Maps [0].transform.rotation));
		//num = Random.Range(0,2);
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(-0,-393,-1170) , Maps [0].transform.rotation));
		//
	}
	
	/*void Update(){
		CreateMap();
	}*/

	public  void CreateMap(){
		if(i>=20){
			i =21;
		}else{

			for(i = 1; i<=20;i++){
				//almentar randon em mais 1
				num = Random.Range(0,3);
				atual.Add ((GameObject)Instantiate (Maps[num],transform.position + new Vector3(0*i,-393*i,-1170*i) , Maps [0].transform.rotation));
				print (num);
			}
		}
	}


}


