using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class direction_ob : MonoBehaviour {
private GameObject tog_n, tog_s, tog_w, tog_e, cam;

	// Use this for initialization
	void Start () {
 tog_n = GameObject.Find("Togg_n");
 tog_s = GameObject.Find("Togg_s");
 tog_w = GameObject.Find("Togg_w");
 tog_e = GameObject.Find("Togg_e");

	}
	
	// Update is called once per frame
	void Update () {
float houi=0.0f;
if (tog_n.GetComponent<Toggle>().isOn){houi=-90.0f;}
if (tog_s.GetComponent<Toggle>().isOn){houi=90.0f;}
if (tog_w.GetComponent<Toggle>().isOn){houi=180.0f;}
if (tog_e.GetComponent<Toggle>().isOn){houi=0.0f;}


transform.Rotate(new Vector3(0f, houi-this.transform.localEulerAngles.y,0f)); 
//transform.Rotate(new Vector3(0f, houi,0f)); 
	}
}