using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_mark : MonoBehaviour {
private TrailRenderer tr_m;

	// Use this for initialization
	void Start () {
	tr_m=this.gameObject.GetComponent<TrailRenderer>();
        tr_m.startWidth=0.1f;
        tr_m.endWidth=0.3f;
        tr_m.material.color=Color.white;
        tr_m.time=20f;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
