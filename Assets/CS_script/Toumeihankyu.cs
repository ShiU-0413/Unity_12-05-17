using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;



public class Toumeihankyu : MonoBehaviour {


public Camera firstPersonCamera;
public Camera overheadCamera;
public GameObject Sl;
public GameObject Button;

void Start() {
 overheadCamera.enabled = false;
 Sl.SetActive(false);
	
}
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
	Sl.SetActive(true);
	Button.SetActive(false);
    }

	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
//}
