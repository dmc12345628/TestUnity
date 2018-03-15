using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickFunction : MonoBehaviour {

    public Button yourButton;
    public Animator animator;
    public string booleanName;
    public bool value;

    

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }


    void OnMouseDown()
    {
        animator.SetBool(booleanName, value);
        Debug.Log(booleanName + " is true now ");
    }

}
