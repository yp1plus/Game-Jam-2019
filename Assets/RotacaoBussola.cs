using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotacaoBussola : MonoBehaviour {
	public GameObject bussola;
	private float tempo;
	public float tempoRotacao = 2;
	public EventButton mov;
	// Use this for initialization
	void Start () {
		tempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		tempo+=Time.deltaTime;
		if (tempo>=tempoRotacao)
		{
			tempo = 0;
			int anguloGiro;
			anguloGiro = Random.Range(1,4);
			Vector3 vetor = new Vector3(0,0,0);
			Quaternion q = Quaternion.Euler(vetor);
			switch (anguloGiro)
			{
				case 1:  
					{
						vetor = new Vector3(0,0,90);
						q = Quaternion.Euler(vetor);
						bussola.transform.rotation = q;
						mov.move_right = 0;
						mov.move_left = -180;
						mov.move_front = 90;
						mov.move_end = -90;				
						break;
					}
				case 2: 
				{
					vetor = new Vector3(0,0,180);
					q = Quaternion.Euler(vetor);
					bussola.transform.rotation = q;
					mov.move_right = 90;
					mov.move_left = -90;
					mov.move_front = -180;
					mov.move_end = 0;				
					break;
				}
				case 3:
				{
					vetor = new Vector3(0,0,270);
					q = Quaternion.Euler(vetor);
					bussola.transform.rotation = q;
					mov.move_right = 0;
					mov.move_left = -180;
					mov.move_front = -90;
					mov.move_end = 90;				
					break;
				} 
				case 4:
				{
					vetor = new Vector3(0,0,360);
					q = Quaternion.Euler(vetor);
					bussola.transform.rotation = q;
					mov.move_right = 90;
					mov.move_left = -90;
					mov.move_front = 0;
					mov.move_end = -180;				
					break;
				} 
			} 

		}
	}
}
