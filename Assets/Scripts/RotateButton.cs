//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Controla a rotação do botão

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButton : MonoBehaviour
{
    private float _time;
    public float rotateTime;
    private bool clockwise;
    public float keepWiseChance;
    private Quaternion CW90, CCW90;
    private int dir;

    void Start()
    {
        _time = 0f;
        clockwise = true;
        CW90 = Quaternion.Euler(0, 0, -90)*Quaternion.Inverse(Quaternion.Euler(0, 0, 0));
        CCW90 = Quaternion.Euler(0, 0, 90)*Quaternion.Inverse(Quaternion.Euler(0, 0, 0));
        dir = 0;
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= rotateTime){
            if (clockwise){
                transform.rotation *= CW90;
                dir++;
            }
            else {
                transform.rotation *= CCW90;
                dir--;
            }
            dir = (dir+4)%4;
            if (Random.Range(0f, 1f) >= keepWiseChance){
                clockwise = !clockwise;
            }
            _time = 0f;
        }
    }

    public int GetDirection(){
        return dir;
    }
}
