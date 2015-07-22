using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayC : MonoBehaviour {
	
	//[SerializeField]
//	private AdPopup _adPopup;
//	[SerializeField]
//	TextureHolder _textureHolder;

	public float _timer = 0.0f;
	int _rayHitPictId = 0;

	[SerializeField]
	public float _sceneJumpTime = 4.0f;

	PanoramaManager _rayHitPanoramaManager;
	
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {

		Vector3 fwd = this.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(this.transform.position, fwd * 300, Color.green);
		RaycastHit objectHit;
		if (Physics.Raycast(this.transform.position, fwd, out objectHit, 300))
		{
			Debug.Log(objectHit.collider.gameObject.name);//衝突したobject名がdebuglogに出る
			//do something if hit object ie

			if(objectHit.collider.tag=="Ad"){

				string pictName = objectHit.collider.gameObject.name;
				int pictId = int.Parse((pictName[pictName.Length-1]).ToString());

				if(objectHit.collider.gameObject.name == "Picture" + pictId) {
					Debug.Log(pictId);
					
					if(_rayHitPictId != pictId) {
						_timer = 0.0f;
						_rayHitPictId = pictId;
						_rayHitPanoramaManager = objectHit.collider.gameObject.GetComponent<PanoramaManager>();
					}
					_timer += Time.deltaTime;
					_rayHitPanoramaManager.CloseToCamera();

				}


			}

		}

		if (_timer >= _sceneJumpTime) {
			Debug.Log (_sceneJumpTime + "秒以上当たりましたよ");
			//Application.LoadLevel("panorama" + _rayHitPictId);



		}


	}

	private void OnTriggerEnter(Collider other)
	{
	}
}


