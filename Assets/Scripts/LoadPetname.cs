using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadPetname : MonoBehaviour {


	void Start () {
		GetComponent<Text>().text = GameControl.control.PetName;
	}

}
