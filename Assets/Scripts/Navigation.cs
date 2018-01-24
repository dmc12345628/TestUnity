using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

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

    public void OnPreparerParcours()
    {
        setCurrentState(MenuStates.PersonalData);
    }

    public void OnBackMainMenu()
    {
        setCurrentState(MenuStates.Main);
    }

    public void setCurrentState(MenuStates state)
    {
        StartCoroutine(buttonDelay(state));
    }

    IEnumerator buttonDelay(MenuStates state)
    {
        yield return new WaitForSeconds(0.3f);
        currenteState = state;
    }
}
