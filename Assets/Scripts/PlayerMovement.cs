//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Movimentar presente pelo labirinto

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	public ControlandoLab referencia;

    public void Move(int dir){
        int y = (int)-transform.position.y;
		int x = (int)transform.position.x;
        
        switch (dir){
            case 0: 
                if(referencia.matrizColuna[y, x] == 1){
                    Debug.Log("SE FUDEU PRA CIMA");
                    SceneManager.LoadScene(0);
                }else{
                        transform.position += (Vector3)Vector2.up;
                }
                break;
            case 1: 
                if(referencia.matrizLinha[y, x+1] == 1){
                    Debug.Log("SE FUDEU PRA DIREITA");
                    SceneManager.LoadScene(0);
                }else{
                        transform.position += (Vector3)Vector2.right;
                }
                break;
            case 2: 
                if(referencia.matrizColuna[y+1, x] == 1){
                    Debug.Log("SE FUDEU PRA BAIXO");
                    SceneManager.LoadScene(0);
                }else{
                        transform.position += (Vector3)Vector2.down;
                }
                break;
            case 3: 
                if(referencia.matrizLinha[y, x] == 1){
                    Debug.Log("SE FUDEU PRA ESQUERDA");
                    SceneManager.LoadScene(0);
                }else{
                        transform.position += (Vector3)Vector2.left;
                }
                break;
        }
    }

}
