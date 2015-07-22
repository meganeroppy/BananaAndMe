using UnityEngine;
using System.Collections;

public class PanoramaManager : MonoBehaviour {

	Transform thisTransform;
	float movePower = 0.01f;

	public void Start() {
		thisTransform = this.transform;
	}

	public void CloseToCamera() {

		Vector3 cameraDir = (Camera.main.transform.position - thisTransform.position).normalized;

		transform.position += cameraDir * movePower;

	}
}
