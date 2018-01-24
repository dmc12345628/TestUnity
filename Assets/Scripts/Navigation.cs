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
        currenteState = MenuStates.PersonalData;
    }

    public void OnBackMainMenu()
    {
        currenteState = MenuStates.Main;
    }
}
