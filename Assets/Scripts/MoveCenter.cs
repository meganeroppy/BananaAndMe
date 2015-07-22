using UnityEngine;
using System.Collections;

public class MoveCenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (transform.childCount);
		for (int i = 0; i < transform.childCount; i++) {
			transform.GetChild(i).name = "kodomo" + i;
		}
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0,0.1f,0);
	}
}
