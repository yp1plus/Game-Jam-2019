//By Giualiano Lourenço, Pedro Darela e Yure Pablo em 31/03/2019
//Random Invert
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButton : MonoBehaviour
{
    public float averageOnTime, averageOffTime;
    private bool on;
    public Sprite spriteOn, spriteOff;
    private Image img;

    void Start()
    {
        img = GetComponent<Image>();
        on = false;
        StartCoroutine(Changing());
    }

    IEnumerator Changing()
    {
        while (true)
        {
            if (on){
                img.sprite = spriteOn;
                yield return new WaitForSeconds(ExpoRandom(averageOnTime));
            }
            else {
                img.sprite = spriteOff;
                yield return new WaitForSeconds(ExpoRandom(averageOffTime));
            }
            on = !on;
        }
    }

    private float ExpoRandom(float lambda)
    {
        float x = Random.value;
        return -Mathf.Log(1 - x) * lambda;
    }

    public int GetInverse(){
        return on ? 1 : 0;
    }
}
