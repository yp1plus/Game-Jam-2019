using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EventButton : MonoBehaviour {
	public GameObject seta;
	private float tempoRotacao = 2, tempo;
	public GameObject player;
	public float xPosition = 9, yPosition = -2, zPosition = -1; 
	private int zRotation = 0;
	public int move_right = 0, move_left = -180, move_front = 90, move_end = -90;
	
	// Use this for initialization
	void Start () {
		tempo = 0;
		player.transform.position = new Vector3(9,-2,-1);
	}
	
	// Update is called once per frame
	void Update () {
		/*float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
		*/
        // Dampen towards the target rotation
		tempo+=Time.deltaTime;
		if (tempo>=tempoRotacao)
		{
			tempo = 0;
        	seta.transform.Rotate(0,0,90, Space.World );
			zRotation+=90;
		}
		if (zRotation>360){
			zRotation -= 360;
		}
	}

	public void OnMouseDown ()
    {
			switch (zRotation){
				case 90: zRotation = -90; break;
				case 180: zRotation = -180; break;
				case 270: zRotation = 90; break;
				case 360: zRotation = 0; break;
			}
			if (zRotation == move_front) yPosition+=0.5f;
			else if (zRotation == move_left) xPosition-=0.5f;
			else if (zRotation == move_end) yPosition-=0.5f;
			else if (zRotation == move_right) xPosition+=0.5f;
			player.transform.position = new Vector3(xPosition,yPosition,zPosition);
			//player.transform.position();
    }

}
