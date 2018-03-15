using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PersonalInformation : MonoBehaviour {

    #region animators
    public Animator btnMaleAnimator;
    public Animator btnFemaleAnimator;
    public Animator MaleAnimator;
    public Animator FemaleAnimator;
    #endregion

	#region form widgets
	public InputField infNomDeLenfant;
	public InputField infAge;
	public Toggle tglOperation;
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

	public static string NOM_DE_LENFANT;
	public static string AGE_DE_LENFANT;

    public enum Sex
    {
        Male,
        Female
	}

	public static Sex SELECTED_SEX;
    public static bool OPERATION_PROGRAMMEE;

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
		NOM_DE_LENFANT = infNomDeLenfant.text;
		AGE_DE_LENFANT = infAge.text;
		OPERATION_PROGRAMMEE = tglOperation.enabled;
		SceneManager.LoadScene("PauseMenu");
	}
    #endregion
}
