using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalDataMenu : MonoBehaviour {

    #region attributes
    public Animator btnMaleAnimator;
    public Animator btnFemaleAnimator;
    public Animator MaleAnimator;
    public Animator FemaleAnimator;
    #endregion

    // Use this for initialization
    void Start () {
        selectedSex = Sex.Male;
	}
	
	// Update is called once per frame
	void Update () {
        bool isMale = selectedSex == Sex.Male;
        btnMaleAnimator.SetBool("SELECTED", isMale);
        MaleAnimator.SetBool("SELECTED", isMale);
        btnFemaleAnimator.SetBool("SELECTED", !isMale);
        FemaleAnimator.SetBool("SELECTED", !isMale);
    }

    #region Form Personal Data

    public string nomDeLenfant;
    public enum Sex
    {
        Male,
        Female
    }
    public Sex selectedSex;

    public void OnNomChange(string nom)
    {
        nomDeLenfant = nom;
    }

    public void OnMaleClick()
    {
        selectedSex = Sex.Male;
    }

    public void OnFemaleClick()
    {
        selectedSex = Sex.Female;
    }

	public void OnValidClick()
	{
		Application.LoadLevel("TestAR");	
	}
    #endregion
}
