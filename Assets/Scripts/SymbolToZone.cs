using UnityEngine;
using System.Collections;

public class SymbolToZone : MonoBehaviour {

	private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			string sceneName = "";
			if(this.gameObject.name.Contains("Home")){
				sceneName = "Select2";
			}else{
				sceneName = "Zone" + this.gameObject.name;
			}

			Application.LoadLevel(sceneName);
		}
	}

}
