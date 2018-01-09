using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeRoll_test : MonoBehaviour {
	//int rotater;
	float i;
	float o;
	int counter;
	string message;
	void start() {
		//rotater = 0;
		i = 1;
		o = 1f;
	}

	void Update () {
		counter++;


		/*if ((i*100 < -50) && (o == -1)) {
			o = 1f;
			i = 1;
		}
		else if ((i*100 > 50) && (o == 1)) {
				o = -1f;
				i = -1;
		}
			*/


		i = 80*Time.deltaTime*o;



		transform.Rotate (0, 0, i);
	}

	void OnGUI()
	{
		message = (i*100).ToString();
		GUI.Label (new Rect (10, 10, 500, 30), message);
	}
}
