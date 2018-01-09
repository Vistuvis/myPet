using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class text_resize : MonoBehaviour {


	Vector2 ref_canvas_size = new Vector2(800f,1200f);

	float ratio;
	float previous_screenheight ;

	// Use this for initialization
	void Start () {
		ratio = ( ref_canvas_size.y / GetComponent<Text> ().fontSize);
		GetComponent<Text> ().fontSize = (int) (GameObject.Find("Canvas").GetComponent<RectTransform>().rect.height / ratio);
		previous_screenheight = GameObject.Find("Canvas").GetComponent<RectTransform>().rect.height;
	}

	// Update is called once per frame
	void Update () {


		if (Screen.height != previous_screenheight) 
		{
			GetComponent<Text> ().fontSize = (int) (GameObject.Find("Canvas").GetComponent<RectTransform>().rect.height / ratio);
		}
		previous_screenheight = GameObject.Find("Canvas").GetComponent<RectTransform>().rect.height;
	}
}
