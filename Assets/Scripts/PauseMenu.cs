using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	#region PersonalInformationDialog
	public Text txtNomDeLenfant;
	public Text txtAge;
	public GameObject pnlMale;
	public GameObject pnlFemale;
	public Toggle tglOperation;
	#endregion

	// Use this for initialization
	void Start () {
		txtNomDeLenfant.text = PersonalInformation.NOM_DE_LENFANT;
		txtAge.text = "Age : " + PersonalInformation.AGE_DE_LENFANT;

		bool isMale = PersonalInformation.SELECTED_SEX == PersonalInformation.Sex.Male;

		pnlMale.SetActive (isMale);
		pnlFemale.SetActive (!isMale);

		tglOperation.isOn = PersonalInformation.OPERATION_PROGRAMMEE;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
