using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
	//script for touch input 

	public LayerMask touchInputMask;
	private RaycastHit hit;
	private List<GameObject> touchList = new List<GameObject>();
	private GameObject[] touchOld;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

#if UNITY_EDITOR
if(Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0)){
	touchOld = new GameObject[touchList.Count];
	touchList.CopyTo(touchOld);
	touchList.Clear();

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray, out hit, touchInputMask)){
			GameObject hitObject = hit.transform.gameObject;

			if(Input.GetMouseButtonDown(0)){
				hitObject.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);

			}
			if(Input.GetMouseButtonUp(0)){
				hitObject.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);

			}
			if(Input.GetMouseButton(0)){
				hitObject.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);

			}
	}
	foreach(GameObject g in touchOld){
		if(!touchList.Contains(g)){
			g.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
		}
	}
}
#endif

		if(Input.touchCount > 0){
			touchOld = new GameObject[touchList.Count];
			touchList.CopyTo(touchOld);
			touchList.Clear();


			foreach(Touch touch in Input.touches){
				Ray ray = Camera.main.ScreenPointToRay(touch.position);

				if(Physics.Raycast(ray, out hit, touchInputMask)){
					GameObject hitObject = hit.transform.gameObject;

					if(touch.phase == TouchPhase.Began){
						hitObject.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);

					}
					if(touch.phase == TouchPhase.Ended){
						hitObject.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);

					}
					if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved){
						hitObject.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);

					}
					if(touch.phase == TouchPhase.Canceled){
						hitObject.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);

					}

				}
			}
			foreach(GameObject g in touchOld){
				if(!touchList.Contains(g)){
					g.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}

	private void handleHomeTouch(){

	}
}
