using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Earth_scale : MonoBehaviour {
public GameObject Earth;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
float sl_value;
sl_value=this.GetComponent<Slider> ().value;

Earth.transform.position = new Vector3(0f, -4.22f*sl_value*-1, 4.22f*sl_value*-1);
Earth.transform.localScale = new Vector3(sl_value*-12,sl_value*-12,sl_value*-12);

	}
}
