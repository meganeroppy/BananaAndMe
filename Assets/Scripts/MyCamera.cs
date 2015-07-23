using UnityEngine;
using System.Collections;

public class MyCamera : MonoBehaviour {


	[SerializeField]
	private Transform player;
	
	[SerializeField]
	private Vector3 offset = new Vector3(0, 0, -5);
	
	// Update is called once per frame
	void Update () {
		this.transform.position =player.position + offset;
	}
}
