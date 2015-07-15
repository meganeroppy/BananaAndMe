using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	[SerializeField]
	private float rotOffsetY = 120f; //degree
	private float defaultRotY = 0f; // degree

	[SerializeField]
	private float rotSpeed = 15f;

	[SerializeField]
	private bool clockwise = true;

	private bool opening = false;

	// Use this for initialization
	void Start () {
		defaultRotY = this.transform.rotation.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(opening){
			float curRotY = this.transform.rotation.eulerAngles.y;

			if(curRotY > defaultRotY + rotOffsetY){
				opening = false;
			}else{
				float add = rotSpeed * Time.deltaTime * (clockwise ? 1 : -1);
				this.transform.Rotate(0, add, 0);
			}
		}
	}

	private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			Open();
		}
	}

	public void Open(){
		Debug.Log("Open()");
		opening = true;
	}
}
