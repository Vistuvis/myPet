using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_set : MonoBehaviour {

	public float Pos_X_Percent;		//gets the distance from the center of screen
	public float Pos_Y_Percent;		//""
	public int layer;

	public int temp;

	public string text;
	Text textobject;

	void Start()
	{
		GetComponent<Text> ().text = text;
		textobject = GetComponent<Text> ();
		
	}


	void Update () {
		
		float posx = Screen.width / 2 * (Pos_X_Percent / 100);
		float posy = Screen.height / 2 * (Pos_Y_Percent / 100);


		Vector3 pos =  new Vector3(posx+(textobject.rectTransform.sizeDelta.x*.5f)*-(Pos_X_Percent/100), Screen.height/2 * (Pos_Y_Percent/100) - (textobject.rectTransform.sizeDelta.y*.5f)*(Pos_Y_Percent/100), Camera.main.nearClipPlane);

		transform.localPosition = pos;

	}
}
