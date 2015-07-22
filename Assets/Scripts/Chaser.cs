using UnityEngine;
using System.Collections;

public class Chaser : MonoBehaviour {

	[SerializeField]
	Transform _targetObject;
	
	// Update is called once per frame
	void Update () {
		transform.rotation = _targetObject.rotation;
		transform.position = _targetObject.position;
		transform.position += Vector3.down * .7f;
	}
}
