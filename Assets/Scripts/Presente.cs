//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Movimentação do presente sobre o labirinto

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presente : MonoBehaviour {

	public ControlandoLab referencia;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		bool w = Input.GetKeyDown(KeyCode.W);
		bool a = Input.GetKeyDown(KeyCode.A);
		bool s = Input.GetKeyDown(KeyCode.S);
		bool d = Input.GetKeyDown(KeyCode.D);
		int y = (int)-transform.position.y;
		int x = (int)transform.position.x;

		if(w){
			if(referencia.matrizColuna[y, x] == 1){
				Debug.Log("SE FUDEU PRA CIMA");
			}else{
				mexepresente(Vector2.up);
			}	
		}else{
			if(a){
				if(referencia.matrizLinha[y, x] == 1){
					Debug.Log("SE FUDEU PRA ESQUERDA");
				}else{
					mexepresente(Vector2.left);
				}	
			}else{
				if(s){
					if(referencia.matrizColuna[y +1, x] == 1){
						Debug.Log("SE FUDEU PRA BAIXO");
					}else{
						mexepresente(Vector2.down);
					}	
				}else{
					if(d){
						if(referencia.matrizLinha[y, x +1] == 1){
							Debug.Log("SE FUDEU PRA DIREITA");
						}else{
							mexepresente(Vector2.right);
						}	
					}
				}
			}
		}

	}

	public void mexepresente(Vector2 direcao){
		transform.position += (Vector3) direcao;
	}
}
