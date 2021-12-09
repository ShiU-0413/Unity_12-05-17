using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class lat_value : MonoBehaviour {

private int lattitude_value;

	// Use this for initialization
	void Start () {

//lattitude_value=45;
        	
	}
	
	// Update is called once per frame
	void Update () {
lattitude_value=(int)GameObject.Find("GameObject_arm_lat").GetComponent<Transform>().transform.localEulerAngles.x;

if (lattitude_value<=90) {
lattitude_value=lattitude_value;

this.GetComponent<Text>().text = "北緯"+lattitude_value.ToString()+"度";
}

if (lattitude_value>90) {
lattitude_value=(lattitude_value-360)*-1;

this.GetComponent<Text>().text = "南緯"+lattitude_value.ToString()+"度";
}

if (lattitude_value==0) {
lattitude_value=0;

this.GetComponent<Text>().text = "赤道(緯度0度)";
}
	//this.GetComponent<Text>().text = "緯度"+lattitude_value.ToString()+"度";

}
}

