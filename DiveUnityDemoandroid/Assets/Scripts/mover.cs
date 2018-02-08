using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public GameObject _camera;
	// Use this for initialization
	void Start () {
		_camera = GameObject.FindGameObjectWithTag("camera");
	}
	
	// Update is called once per frame
	void Update () {
		_camera.transform.position = this.transform.position;
	}
}
