using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraControl : MonoBehaviour {
private GameObject tog_o, tog_s;
private GameObject MainCam,StaCam;

	// Use this for initialization
	void Start () {
tog_o = GameObject.Find("Tog_Observer");
tog_s = GameObject.Find("Tog_Static");
MainCam = GameObject.Find("Main Camera");
StaCam = GameObject.Find("StaticCamera");

	}
	
	// Update is called once per frame
	void Update () {
// tog_o = GameObject.Find("Tog_Observer");
 //tog_s = GameObject.Find("Tog_Static");


// MainCam = GameObject.Find("Main Camera");
// StaCam = GameObject.Find("Static Camera");

if (tog_o.GetComponent<Toggle>().isOn){
MainCam.SetActive(true);
StaCam.SetActive(false);
}

if (tog_s.GetComponent<Toggle>().isOn){
StaCam.SetActive(true);
MainCam.SetActive(false);
}


	}
}