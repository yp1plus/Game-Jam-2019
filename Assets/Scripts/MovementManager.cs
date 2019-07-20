//By Giualiano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Movimento da bússola 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public RotateButton Direction;
    public RandomButton North;
    public ChangeButton Invert;
    public PlayerMovement Player;

    public void Click(){
        Debug.Log("Clicou");
        int dir = Direction.GetDirection();
        int north = North.GetDirection();
        int inverse = Invert.GetInverse();
        Player.Move((dir + north + inverse * 2) % 4);
    }

}
