using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	public void OnClickButton(int num){
		Application.LoadLevel ("panorama" + num);
	}
}
