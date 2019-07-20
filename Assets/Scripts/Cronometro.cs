//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Contador do jogo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour {

	public Text contador;
	public GameObject presente;

	Vector3 vetor = new Vector3();
	Vector3 inicio = new Vector3(9, -2, -1);
	public float contagem = 30.0f;

	private int repeticao = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		vetor = presente.transform.position;

		if(contagem > 0){
			contagem -= Time.deltaTime;
			contador.text = contagem.ToString();
			if(vetor.x == 10 && vetor.y == -4){
				contagem = 30.0f;
				presente.transform.position = inicio;
				repeticao++;

			}
		}else{
			contador.text = "SE FUDEU";
			Invoke("Perdeu", 1f);
		}
	}

	void Perdeu(){
		SceneManager.LoadScene(0);
	}
}
