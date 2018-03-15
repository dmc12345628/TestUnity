using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour {

    public Transform camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Position = new Vector3(camera.transform.position.x, this.transform.position.y, this.transform.position.z);
        //Vector3 Position = new Vector3(this.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        //Vector3 Position = new Vector3(camera.transform.position.x, camera.transform.position.y, this.transform.position.z);

        this.transform.LookAt(Position);
	}
}
