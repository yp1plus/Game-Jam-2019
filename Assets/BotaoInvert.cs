//Produzido por Giuliano Lourenço, Yure Pablo e...
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoInvert : MonoBehaviour {
	private float tempo, tempoInvert = 10;
	public EventButton mov;

	// Use this for initialization
	void Start () {
		tempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (tempo>=tempoInvert)
			{
				tempo = 0;
				int move = mov.move_right;
				mov.move_right = mov.move_left;
				mov.move_left = move;
				move = mov.move_front;
				mov.move_front = mov.move_end;
				mov.move_end = move; 
		    }
	}
}
