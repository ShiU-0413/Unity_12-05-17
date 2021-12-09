using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Starselect : MonoBehaviour {

private GameObject tog_r, tog_g, tog_b;
private GameObject star_r, star_g, star_b;

	// Use this for initialization
	void Start () {
tog_r = GameObject.Find("Tog_red");
tog_g = GameObject.Find("Tog_green");
tog_b = GameObject.Find("Tog_blue");
	
star_r = GameObject.Find("RedStar");
star_g = GameObject.Find("GreenStar");
star_b = GameObject.Find("BlueStar");


	}
	
	// Update is called once per frame
	void Update () {

if (tog_r.GetComponent<Toggle>().isOn){

star_r.layer = 10;
star_g.layer = 14;
star_b.layer = 14;
}

if (tog_g.GetComponent<Toggle>().isOn){

star_r.layer = 14;
star_g.layer = 10;
star_b.layer = 14;
}
		
if (tog_b.GetComponent<Toggle>().isOn){

star_r.layer = 14;
star_g.layer = 14;
star_b.layer = 10;
}

	}
}
