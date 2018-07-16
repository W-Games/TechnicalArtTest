using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Spin : MonoBehaviour {

	[Range(0f, 50f)]
	public float speed = 5f;
	// Use this for initialization
	void OnEnable () {
		EditorApplication.update += Update;
	}
	void OnDisable () {
		EditorApplication.update -= Update;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(0f, 0f, (float) EditorApplication.timeSinceStartup * speed);
	}
}
