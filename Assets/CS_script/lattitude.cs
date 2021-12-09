using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lattitude : MonoBehaviour {
private GameObject sl_lat;
	// Use this for initialization
	void Start () {
	sl_lat = GameObject.Find("sl_lat");	
//	lat_value = GameObject.Find("lat_value");	
	}
	
	// Update is called once per frame
	void Update () {
float sl_value;
//	transform.Rotate =(new Vector3(60f, 0.0f, 0.0f));	
//	print(this.transform.eulerAngles.x);
sl_value=sl_lat.GetComponent<Slider> ().value;

if (sl_value>=0){
	transform.Rotate(new Vector3(90.0f-sl_value-this.transform.localEulerAngles.x,0f,0f)); // y軸を軸として90°回転

//transform.Rotate(new Vector3(sl_value-this.transform.localEulerAngles.x,0f,0f)); // y軸を軸として90°回転


}


if (sl_value<0){
	transform.Rotate(new Vector3(-90.0f-sl_value+this.transform.localEulerAngles.x,0f,0f)); // y軸を軸として90°回転

}
	//transform.rotate =(new Vector3(sl_lat.GetComponent<Slider> ().value, 0.0f, 0.0f));	
//	transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
	}
}
