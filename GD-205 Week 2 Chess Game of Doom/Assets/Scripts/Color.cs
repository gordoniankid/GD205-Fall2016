using UnityEngine;
using System.Collections;

public class Color : MonoBehaviour {
	private static UnityEngine.Color red;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		GetComponent<Renderer>().material.color = Color.red;

	}
}
