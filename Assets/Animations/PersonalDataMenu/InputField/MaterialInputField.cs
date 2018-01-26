using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialInputField : MonoBehaviour {

    #region attributes

    public InputField inputField;
    public Text text;
    public Animator textAnimator;
    public Animator lineAnimator;

    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // if infNomDeLenfant is focused or it does not have text
        bool isFocused = inputField.isFocused || inputField.text.ToString().Length > 0;

        text.fontSize = isFocused ? 14 : 16;
        textAnimator.SetBool("FOCUSED", isFocused);
        lineAnimator.SetBool("FOCUSED", isFocused);
    }
}
