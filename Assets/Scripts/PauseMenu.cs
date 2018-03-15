using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	#region PersonalInformationDialog
	public Text txtTitle;
	#endregion

	// Use this for initialization
	void Start () {
		txtTitle.text = PersonalInformation.NOM_DE_LENFANT;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
