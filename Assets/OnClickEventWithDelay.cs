using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickEventWithDelay : MonoBehaviour {


    public Button yourButton;
    public Animator animator;
    public string booleanName;
    public bool value;

    public float delay;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }


    void OnMouseDown()
    {
        StartCoroutine(CoroutineFunction());
    }


    IEnumerator CoroutineFunction()
    {
        yield return new WaitForSeconds(delay);
        animator.SetBool(booleanName, value);
    }
}


