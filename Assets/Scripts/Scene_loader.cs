using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_loader : MonoBehaviour {

	public string SceneToLoad;

	public void LoadScene(){
		GameControl.control.leveltoload = SceneToLoad;
		GameControl.control.loadlevel = true;
	}
}
