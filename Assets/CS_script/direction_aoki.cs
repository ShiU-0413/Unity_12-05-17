using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class direction_aoki : MonoBehaviour {
private GameObject tog_n, tog_s, tog_w, tog_e, cam;
private GameObject sl_lat;

	// Use this for initialization
	void Start () {
 tog_n = GameObject.Find("Togg_n");
 tog_s = GameObject.Find("Togg_s");
 tog_w = GameObject.Find("Togg_w");
 tog_e = GameObject.Find("Togg_e");

	sl_lat = GameObject.Find("sl_lat");

	}
	
	// Update is called once per frame
	void Update () {
float sl_value;
sl_value=sl_lat.GetComponent<Slider> ().value;

float houi=0.0f;
float dir_x=0f;
float dir_z=0f;

if (tog_n.GetComponent<Toggle>().isOn)
{
if (sl_value>=0f && sl_value <45f){
dir_x=-sl_value;}

if (sl_value>=45f && sl_value <90f){
dir_x=-60f+0.3333333f*sl_value;}

if (sl_value>=90f && sl_value <135f){
dir_x=-30f;}

if (sl_value>=135f && sl_value <=180f){
dir_x=-120f+0.6666667f*sl_value;}

houi=-90.0f;
dir_z=0f;
}

if (tog_s.GetComponent<Toggle>().isOn)
{
if (sl_value>=0f && sl_value <45f){
dir_x=-0.6666667f*sl_value;}
//dir_x=-sl_value;}

if (sl_value>=45f && sl_value <90f){
dir_x=-30f;}
//dir_x=-60f+0.3333333f*sl_value;}

if (sl_value>=90f && sl_value <135f){
dir_x=-0.3333333f*sl_value;}
//dir_x=-30f;}

if (sl_value>=135f && sl_value <=180f){
dir_x=-180f+sl_value;}
//dir_x=-120f+0.6666667f*sl_value;}

houi=90.0f;
dir_z=0f;
}
if (tog_w.GetComponent<Toggle>().isOn){houi=180.0f;}
if (tog_e.GetComponent<Toggle>().isOn){houi=0.0f;}


transform.Rotate(new Vector3(dir_x-this.transform.localEulerAngles.x, houi-this.transform.localEulerAngles.y,dir_z-this.transform.localEulerAngles.z)); 
//transform.Rotate(new Vector3(0f, houi,0f)); 
	}
}

