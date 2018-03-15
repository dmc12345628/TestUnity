using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBooleanAnimator : MonoBehaviour {

    public Animator animator;
    public string booleaName;
    public bool value;

	// Use this for initialization
	void Start () {
        animator.SetBool(booleaName, value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
