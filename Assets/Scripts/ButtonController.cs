using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
	//script for button functionality

		//if certain buttons are needed use those
		//public Button home;
		//public Button photo;
		//public Button get;
		//public Button settings;
		//public Button func5;
		//public Button func6;

		public GameObject canvas;

	// Use this for initialization
	void Start () {
		canvas = GameObject.Find("Canvas");
	}

	// Update is called once per frame
	void Update () {

	}

	public void handleHomeTouch(){
		SceneManager.LoadScene("HomeScene");
		print("Hombe button pressed.");
	}

	public void handlePhotoTouch(){
		SceneManager.LoadScene("CameraScene");
		print("Camera button pressed");
	}

	public void handleGetTouch(){
		SceneManager.LoadScene("GetScene");
		print("Get button pressed.");
	}

	public void handleSettingsTouch(){
		//SceneManager.LoadScene("SettingsScene");
		//print("Settings button pressed.");
	}

}
