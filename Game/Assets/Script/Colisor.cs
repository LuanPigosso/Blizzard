using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Colisor : MonoBehaviour {

	public GameObject invisible;

	//points
	public UnityEngine.UI.Text txtPoints;
	public static int points;

	float contPoints;
	float contRecord;
	public static string qtpontos;
	public static string record;

	static string key;

	void start(){
		key = "highscore";
		qtpontos = "pontos";
		points = 0;
		contPoints = 0;
		PlayerPrefs.SetInt("points", points);
	}

	void update(){
		txtPoints.text = points.ToString();
	}

	void OnCollisionEnter(Collision collisionInfo){
		
		if(collisionInfo.gameObject.tag == "GameOver"){
			if (PlayerPrefs.HasKey (key)) {// key é o nome da variavel
				
				contRecord = PlayerPrefs.GetFloat (key);
				
				if (highscore > myscore) { // highscore é o melhor score gravado
					
					PlayerPrefs.SetFloat (key, myscore); //myscore é o score da partida
					
					highscore = myscore;
					//score = myscore;
					
					//audioFinish.clip = win;
					PlayerPrefs.Save ();
					
				}
			    //score = highscore;
                print ("key"+PlayerPrefs.GetFloat (key));

            } else {
				// se nao tem save, ele cria agora!!!
				PlayerPrefs.SetFloat (key, myscore);
				PlayerPrefs.Save ();
                 print (PlayerPrefs.GetFloat (key));
			}*/
	/*		PlayerPrefs.SetInt("points", points);
			if(qtpontos > PlayerPrefs.GetInt("records")){
				PlayerPrefs.SetInt("records", qtpontos);

			}*/

			if (contPoints > contRecord){
				contRecord = contPoints;
				record = contRecord.ToString();
			}
			print("points colisor " + qtpontos);
			Application.LoadLevel("GameOver");
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Prox"){
			print("novo mapa");
			invisible.GetComponent<VectorMap>().CreateMap();
		}if(other.tag == "Coin"){
			//print("1 Coin");
			Destroy(other.gameObject);
			Pontos.points += 1;
			contPoints ++;
			qtpontos = contPoints.ToString();
			print("cont pontos " + contPoints);
			print("qtpontos " + qtpontos);
		}
	}

}
