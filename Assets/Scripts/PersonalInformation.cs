using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonalInformation : MonoBehaviour {

    #region attributes
    public Animator btnMaleAnimator;
    public Animator btnFemaleAnimator;
    public Animator MaleAnimator;
    public Animator FemaleAnimator;
	public InputField infNomDeLenfant;
	public InputField infAge;
    #endregion

    // Use this for initialization
    void Start () {
        SELECTED_SEX = Sex.Male;
	}
	
	// Update is called once per frame
	void Update () {
        bool isMale = SELECTED_SEX == Sex.Male;
        btnMaleAnimator.SetBool("SELECTED", isMale);
        MaleAnimator.SetBool("SELECTED", isMale);
        btnFemaleAnimator.SetBool("SELECTED", !isMale);
        FemaleAnimator.SetBool("SELECTED", !isMale);
    }

    #region Form Personal Data

	public static string NO_DE_LENFANT;
	public static string AGE_DE_LENFANT;

    public enum Sex
    {
        Male,
        Female
	}

	public static Sex SELECTED_SEX;

	public void OnNomChange()
	{
		string newNom = infNomDeLenfant.text;
		NO_DE_LENFANT = newNom;
	}

	public void OnAgeChange()
	{
		string newAge = infAge.text;
		AGE_DE_LENFANT = newAge;
	}

    public void OnMaleClick()
    {
        SELECTED_SEX = Sex.Male;
    }

    public void OnFemaleClick()
    {
        SELECTED_SEX = Sex.Female;
    }

	public void OnValidClick()
	{
		Application.LoadLevel("TestAR");	
	}
    #endregion
}
