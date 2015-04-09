using System.Collections;
using UnityEngine;
	
public class TargetFrameRate : MonoBehaviour {
	
	public int target = 30;
	
	void Start(){
		QualitySettings.vSyncCount=0;
	}
	
	void Update() {
		if(target != Application.targetFrameRate){
			Application.targetFrameRate = target;
		}
	}
}