using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {
	
	public static GameControl control;
	public bool loadlevel;
	public string leveltoload;

	public string PlayerName;
	public string PetName;

	string message;

	Scene currentScene;
	void Awake () 
	{
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}


	}
	void Update ()
	{
		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name != leveltoload) {
			SceneManager.LoadScene (leveltoload);
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 500, 30), message);
	}

	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerinfo.dat");
		Playerdata data = new Playerdata ();
		data.Name = "Waylon";
		data.Petname = "Jelly";

		bf.Serialize (file, data);
		file.Close();
		message = "save COMPLETE";
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/playerinfo.dat")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			Playerdata data = (Playerdata)bf.Deserialize (file);

			PlayerName = data.Name;
			PetName = data.Petname;
			message = "load Complete";

		}
	}
		
		
}

[Serializable]
class Playerdata
{
	public String Name;
	public String Petname;
}
