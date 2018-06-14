using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour {

	private string name;

	//use those buttons if you want to change signIn and signUp buttons
	//public Button signIn;
	//public Button signUp;
	public GameObject canvas;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void handleSignIn(){
		//todo open name and pw input fields
		setActiveSignIn();
		setFalseWelcomeUI();

	}

	public void handleSignUp(){
		//todo open sign up input fields (name, mail, username, etc)
	}

	public void handleBackButton(){
		setFalseSignIn();
		setActiveWelcomeUI();
	}

	private void setActiveSignIn(){
		canvas.gameObject.transform.GetChild(16).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(17).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(18).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(19).gameObject.SetActive(true);
	}

	private void setActiveWelcomeUI(){
		canvas.gameObject.transform.GetChild(11).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(12).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(13).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(14).gameObject.SetActive(true);
		canvas.gameObject.transform.GetChild(15).gameObject.SetActive(true);
	}

	private void setFalseWelcomeUI(){
		canvas.gameObject.transform.GetChild(11).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(12).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(13).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(14).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(15).gameObject.SetActive(false);
	}

	private void setFalseSignIn(){
		canvas.gameObject.transform.GetChild(16).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(17).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(18).gameObject.SetActive(false);
		canvas.gameObject.transform.GetChild(19).gameObject.SetActive(false);
	}

	public void handleQuitButton(){
		Application.Quit();
	}
}
