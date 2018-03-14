using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	#region animators
	public Animator confirmDialogAnimator;
	#endregion

	// Use this for initialization
	void Start () {
		currenteState = MenuStates.GameView;
		confirmDialogAnimator = confirmDialog.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		gameView.SetActive (currenteState == MenuStates.GameView);
		//gameMenu.SetActive (currenteState == MenuStates.GameMenu);
		pauseMenu.SetActive (currenteState == MenuStates.PauseMenu || currenteState == MenuStates.ConfirmDialog);

		if (currenteState == MenuStates.ConfirmDialog) {
			confirmDialog.SetActive (true);
			confirmDialogAnimator.SetBool ("SHOW", true);
		}
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

	public void OnStopGame()
	{
		currenteState = MenuStates.ConfirmDialog;
	}

	#region OnClicksDialog
	public void OnAcceptDialog()
	{
		SceneManager.LoadScene("MainScene");
	}

	public void OnCancelDialog()
	{
		//HideConfirmDialog ();

		Debug.Log ("SHOW FALSE");
		confirmDialogAnimator.SetBool ("SHOW", false);
		SetCurrentState (MenuStates.PauseMenu);
	}

	#endregion

	#region Coroutines
	public void SetCurrentState(MenuStates state)
	{
		StartCoroutine(MenuButtonDelay(state));
	}

	IEnumerator MenuButtonDelay(MenuStates state)
	{
		yield return new WaitForSeconds(0.3f);
		currenteState = state;
	}

	public void HideConfirmDialog() {
		StartCoroutine (HideConfirmDialogDelay());
	}

	IEnumerator HideConfirmDialogDelay() {
		yield return new WaitForSeconds (1f);
		confirmDialog.SetActive (false);
	}
	#endregion
		
	#endregion
}
