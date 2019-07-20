//By Giuliano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Controla o tempo de rotação do botão

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButton : MonoBehaviour
{
    public List<Sprite> sprites;
    private float _time, rTime;
    public float randomTimeMin, randomTimeMax;
    private Image img;
    private int dir;

    void Start()
    {
        _time = 0f;
        rTime = Random.Range(randomTimeMin, randomTimeMax);
        img = GetComponent<Image>();
        dir = 0;
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= rTime){
            dir = Random.Range(0, sprites.Count);
            img.sprite = sprites[dir];
            _time = 0f;
            rTime = Random.Range(randomTimeMin, randomTimeMax);            
        }
    }

    public int GetDirection(){
        return dir;
    }
}
