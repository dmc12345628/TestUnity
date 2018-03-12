using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

	public enum MenuStates
	{
		GameView,
		GameMenu,
		PauseMenu,
		ConfirmDialog
	}
	public MenuStates currenteState;

	public GameObject gameView;
	//public GameObject gameMenu;
	public GameObject pauseMenu;
	public GameObject confirmDialog;

	// Use this for initialization
	void Start () {
		currenteState = MenuStates.GameView;
	}
	
	// Update is called once per frame
	void Update () {
		gameView.SetActive (currenteState == MenuStates.GameView);
		//gameMenu.SetActive (currenteState == MenuStates.GameMenu);
		pauseMenu.SetActive (currenteState == MenuStates.PauseMenu);
		confirmDialog.SetActive (currenteState == MenuStates.ConfirmDialog);
	}

	#region OnClicks
	public void OnPauseGame() 
	{
		SetCurrentState (MenuStates.PauseMenu);
	}

	public void OnResumeGame() 
	{
		SetCurrentState (MenuStates.GameView);
	}

	public void OnBackMainScene()
	{
		SetCurrentState (MenuStates.ConfirmDialog);
	}

	#region OnClicksDialog
	public void OnAcceptDialog()
	{
		Application.LoadLevel ("MainScene");
	}

	public void OnCancelDialog()
	{
		SetCurrentState (MenuStates.PauseMenu);
	}

	#endregion

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
