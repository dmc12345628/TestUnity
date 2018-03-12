using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

	public enum MenuStates
	{
		CameraView,
		GameMenu,
		PauseMenu
	}
	public MenuStates currenteState;

	public GameObject cameraView;
	public GameObject gameMenu;
	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		currenteState = MenuStates.CameraView;
	}
	
	// Update is called once per frame
	void Update () {
		cameraView.SetActive (currenteState == MenuStates.CameraView);
		gameMenu.SetActive (currenteState == MenuStates.GameMenu);
		pauseMenu.SetActive (currenteState == MenuStates.PauseMenu);
	}

	#region OnClicks
	public void OnPauseGame() 
	{
		SetCurrentState (MenuStates.PauseMenu);
	}

	public void OnBackMainScene()
	{
		Application.LoadLevel ("MainScene");	
	}

	public void SetCurrentState(MenuStates state)
	{
		StartCoroutine(MenuButtonDelay(state));
	}

	IEnumerator MenuButtonDelay(MenuStates state)
	{
		yield return new WaitForSeconds(0.3f);
		currenteState = state;
	}
	#endregion
}
