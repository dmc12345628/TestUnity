using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour {

    public enum MenuStates
    {
        Main,
        PersonalData,
        Companions
    }
    public MenuStates currenteState;

    public GameObject mainMenu;
    public GameObject personalDataMenu;

	// Use this for initialization
	void Start ()
    {
        currenteState = MenuStates.Main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mainMenu.SetActive(currenteState == MenuStates.Main);
        personalDataMenu.SetActive(currenteState == MenuStates.PersonalData);
    }

    #region OnClicks
    public void OnPreparerParcours()
    {
        SetCurrentState(MenuStates.PersonalData);
    }

    public void OnBackMainMenu()
    {
        SetCurrentState(MenuStates.Main);
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
