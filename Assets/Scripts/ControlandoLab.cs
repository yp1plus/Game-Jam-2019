//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Criando labirinto...

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlandoLab : MonoBehaviour {

	public GameObject[] objetos;
	public GameObject presente;
	public int nLinhas, nColunas;
	
	public int[,] matrizLinha;
	public int[,] matrizColuna;


	// Use this for initialization
	void Start () {
		matrizLinha = new int[nLinhas, nColunas+1];
		matrizColuna =  new int[nLinhas+1, nColunas];

		matrizLinha[0, 0] = 1;
		matrizLinha[0, 1] = 0;
		matrizLinha[0, 2] = 0;
		matrizLinha[0, 3] = 1;
		matrizLinha[0, 4] = 0;
		matrizLinha[0, 5] = 0;
		matrizLinha[0, 6] = 0;
		matrizLinha[0, 7] = 0;
		matrizLinha[0, 8] = 0;
		matrizLinha[0, 9] = 0;
		matrizLinha[0, 10] = 1;
		matrizLinha[1, 0] = 1;
		matrizLinha[1, 1] = 1;
		matrizLinha[1, 2] = 0;
		matrizLinha[1, 3] = 1;
		matrizLinha[1, 4] = 1;
		matrizLinha[1, 5] = 0;
		matrizLinha[1, 6] = 0;
		matrizLinha[1, 7] = 1;
		matrizLinha[1, 8] = 0;
		matrizLinha[1, 9] = 0;
		matrizLinha[1, 10] = 1;
		matrizLinha[2, 0] = 1;
		matrizLinha[2, 1] = 1;
		matrizLinha[2, 2] = 0;
		matrizLinha[2, 3] = 1;
		matrizLinha[2, 4] = 1;
		matrizLinha[2, 5] = 0;
		matrizLinha[2, 6] = 0;
		matrizLinha[2, 7] = 0;
		matrizLinha[2, 8] = 0;
		matrizLinha[2, 9] = 1;
		matrizLinha[2, 10] = 0;
		matrizLinha[3, 0] = 1;
		matrizLinha[3, 1] = 1;
		matrizLinha[3, 2] = 0;
		matrizLinha[3, 3] = 0;
		matrizLinha[3, 4] = 1;
		matrizLinha[3, 5] = 1;
		matrizLinha[3, 6] = 0;
		matrizLinha[3, 7] = 1;
		matrizLinha[3, 8] = 1;
		matrizLinha[3, 9] = 0;
		matrizLinha[3, 10] = 1;
		matrizLinha[4, 0] = 1;
		matrizLinha[4, 1] = 1;
		matrizLinha[4, 2] = 1;
		matrizLinha[4, 3] = 0;
		matrizLinha[4, 4] = 0;
		matrizLinha[4, 5] = 0;
		matrizLinha[4, 6] = 1;
		matrizLinha[4, 7] = 1;
		matrizLinha[4, 8] = 1;
		matrizLinha[4, 9] = 0;
		matrizLinha[4, 10] = 0;
		matrizLinha[5, 0] = 1;
		matrizLinha[5, 1] = 0;
		matrizLinha[5, 2] = 1;
		matrizLinha[5, 3] = 1;
		matrizLinha[5, 4] = 1;
		matrizLinha[5, 5] = 1;
		matrizLinha[5, 6] = 1;
		matrizLinha[5, 7] = 1;
		matrizLinha[5, 8] = 0;
		matrizLinha[5, 9] = 0;
		matrizLinha[5, 10] = 1;
		matrizLinha[6, 0] = 1;
		matrizLinha[6, 1] = 0;
		matrizLinha[6, 2] = 1;
		matrizLinha[6, 3] = 1;
		matrizLinha[6, 4] = 1;
		matrizLinha[6, 5] = 1;
		matrizLinha[6, 6] = 1;
		matrizLinha[6, 7] = 1;
		matrizLinha[6, 8] = 0;
		matrizLinha[6, 9] = 0;
		matrizLinha[6, 10] = 1;
		matrizLinha[7, 0] = 1;
		matrizLinha[7, 1] = 1;
		matrizLinha[7, 2] = 1;
		matrizLinha[7, 3] = 0;
		matrizLinha[7, 4] = 1;
		matrizLinha[7, 5] = 1;
		matrizLinha[7, 6] = 0;
		matrizLinha[7, 7] = 1;
		matrizLinha[7, 8] = 0;
		matrizLinha[7, 9] = 0;
		matrizLinha[7, 10] = 1;
		matrizLinha[8, 0] = 1;
		matrizLinha[8, 1] = 1;
		matrizLinha[8, 2] = 1;
		matrizLinha[8, 3] = 0;
		matrizLinha[8, 4] = 0;
		matrizLinha[8, 5] = 1;
		matrizLinha[8, 6] = 0;
		matrizLinha[8, 7] = 0;
		matrizLinha[8, 8] = 0;
		matrizLinha[8, 9] = 0;
		matrizLinha[8, 10] = 1;
		matrizLinha[9, 0] = 1;
		matrizLinha[9, 1] = 0;
		matrizLinha[9, 2] = 0;
		matrizLinha[9, 3] = 1;
		matrizLinha[9, 4] = 0;
		matrizLinha[9, 5] = 0;
		matrizLinha[9, 6] = 0;
		matrizLinha[9, 7] = 0;
		matrizLinha[9, 8] = 0;
		matrizLinha[9, 9] = 0;
		matrizLinha[9, 10] = 1;

		matrizColuna[0, 0] = 1;
		matrizColuna[0, 1] = 1;
		matrizColuna[0, 2] = 1;
		matrizColuna[0, 3] = 1;
		matrizColuna[0, 4] = 1;
		matrizColuna[0, 5] = 1;
		matrizColuna[0, 6] = 1;
		matrizColuna[0, 7] = 1;
		matrizColuna[0, 8] = 1;
		matrizColuna[0, 9] = 1;
		matrizColuna[1, 0] = 0;
		matrizColuna[1, 1] = 1;
		matrizColuna[1, 2] = 0;
		matrizColuna[1, 3] = 0;
		matrizColuna[1, 4] = 1;
		matrizColuna[1, 5] = 1;
		matrizColuna[1, 6] = 1;
		matrizColuna[1, 7] = 0;
		matrizColuna[1, 8] = 1;
		matrizColuna[1, 9] = 1;
		matrizColuna[2, 0] = 0;
		matrizColuna[2, 1] = 0;
		matrizColuna[2, 2] = 1;
		matrizColuna[2, 3] = 0;
		matrizColuna[2, 4] = 0;
		matrizColuna[2, 5] = 1;
		matrizColuna[2, 6] = 1;
		matrizColuna[2, 7] = 1;
		matrizColuna[2, 8] = 1;
		matrizColuna[2, 9] = 0;
		matrizColuna[3, 0] = 0;
		matrizColuna[3, 1] = 1;
		matrizColuna[3, 2] = 1;
		matrizColuna[3, 3] = 0;
		matrizColuna[3, 4] = 0;
		matrizColuna[3, 5] = 1;
		matrizColuna[3, 6] = 1;
		matrizColuna[3, 7] = 0;
		matrizColuna[3, 8] = 0;
		matrizColuna[3, 9] = 1;
		matrizColuna[4, 0] = 0;
		matrizColuna[4, 1] = 0;
		matrizColuna[4, 2] = 1;
		matrizColuna[4, 3] = 1;
		matrizColuna[4, 4] = 1;
		matrizColuna[4, 5] = 0;
		matrizColuna[4, 6] = 0;
		matrizColuna[4, 7] = 0;
		matrizColuna[4, 8] = 1;
		matrizColuna[4, 9] = 0;
		matrizColuna[5, 0] = 0;
		matrizColuna[5, 1] = 0;
		matrizColuna[5, 2] = 0;
		matrizColuna[5, 3] = 1;
		matrizColuna[5, 4] = 0;
		matrizColuna[5, 5] = 1;
		matrizColuna[5, 6] = 0;
		matrizColuna[5, 7] = 0;
		matrizColuna[5, 8] = 1;
		matrizColuna[5, 9] = 1;
		matrizColuna[6, 0] = 0;
		matrizColuna[6, 1] = 1;
		matrizColuna[6, 2] = 0;
		matrizColuna[6, 3] = 0;
		matrizColuna[6, 4] = 0;
		matrizColuna[6, 5] = 0;
		matrizColuna[6, 6] = 0;
		matrizColuna[6, 7] = 1;
		matrizColuna[6, 8] = 1;
		matrizColuna[6, 9] = 0;
		matrizColuna[7, 0] = 1;
		matrizColuna[7, 1] = 0;
		matrizColuna[7, 2] = 0;
		matrizColuna[7, 3] = 0;
		matrizColuna[7, 4] = 0;
		matrizColuna[7, 5] = 0;
		matrizColuna[7, 6] = 0;
		matrizColuna[7, 7] = 0;
		matrizColuna[7, 8] = 1;
		matrizColuna[7, 9] = 1;
		matrizColuna[8, 0] = 0;
		matrizColuna[8, 1] = 0;
		matrizColuna[8, 2] = 1;
		matrizColuna[8, 3] = 1;
		matrizColuna[8, 4] = 0;
		matrizColuna[8, 5] = 0;
		matrizColuna[8, 6] = 1;
		matrizColuna[8, 7] = 1;
		matrizColuna[8, 8] = 1;
		matrizColuna[8, 9] = 0;
		matrizColuna[9, 0] = 0;
		matrizColuna[9, 1] = 0;
		matrizColuna[9, 2] = 0;
		matrizColuna[9, 3] = 1;
		matrizColuna[9, 4] = 1;
		matrizColuna[9, 5] = 1;
		matrizColuna[9, 6] = 1;
		matrizColuna[9, 7] = 1;
		matrizColuna[9, 8] = 1;
		matrizColuna[9, 9] = 0;
		matrizColuna[10, 0] = 1;
		matrizColuna[10, 1] = 1;
		matrizColuna[10, 2] = 1;
		matrizColuna[10, 3] = 1;
		matrizColuna[10, 4] = 1;
		matrizColuna[10, 5] = 1;
		matrizColuna[10, 6] = 1;
		matrizColuna[10, 7] = 1;
		matrizColuna[10, 8] = 1;
		matrizColuna[10, 9] = 1;

		for(int x = 0; x < nLinhas; x++){
			for(int y = 0; y < nColunas; y++){
				Vector3 posicao = new Vector3(y, -x, 0);
				//Debug.Log(posicao);
				GameObject g = Instantiate(objetos[EscolheFigura(x, y)], posicao, Quaternion.identity);
				g.transform.parent = transform;
			}
		}
		
	}
	
	int EscolheFigura(int x, int y){
		if(matrizLinha[x, y] == 0){
			if(matrizLinha[x, y+1] == 0){
				if(matrizColuna[x, y] == 0){
					if(matrizColuna[x+1, y] == 0){
						//FIGURA TODA BRANCA
						return 0;
					}
					else{
						//FIGURA LADO DE BAIXO
						return 3;
					}
				}
				else{
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO DE CIMA
						return 1;
					}
					else{
						//FIGURA LADO DE CIMA E BAIXO
						return 5;
					}
				}
			}
			else{
				if(matrizColuna[x, y] == 0){
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO DIREITO
						return 2;
					}
					else{
						//FIGURA LADO BAIXO E DIREITO
						return 8;
					}
				}
				else{
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO DIREITO E CIMA
						return 9;
					}
					else{
						//FIGURA LADO BAIXO, DIREITA E CIMA	
						return 13;
					}
				}
			}
		}
		else{
			if(matrizLinha[x, y+1] == 0){
				if(matrizColuna[x, y] == 0){
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO ESQUERDO
						return 4;
					}
					else{
						//FIGURA LADO ESQUERDO E BAIXO
						return 7;
					}
				}
				else{
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO CIMA E ESQUERDA
						return 10;
					}
					else{
						//FIGURA LADO CIMA, ESQUERDA E BAIXO
						return 11;
					}
				}
			}
			else{
				if(matrizColuna[x, y] == 0){
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO ESQUERDO E DIREITO
						return 6;
					}
					else{
						//FIGURA LADO ESQUERDA, BAIXO E DIREITA	
						return 12;
					}
				}
				else{
					if(matrizColuna[x+1, y] == 0){
						//FIGURA LADO DIREITA, CIMA E ESQUERDA
						return 14;
					}
					else{
						//FIGURA TODOS OS LADOS
						return 15;
					}
				}
			}
		}
	}

	
}
