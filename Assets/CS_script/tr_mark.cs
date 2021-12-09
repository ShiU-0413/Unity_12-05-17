using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_symbol : MonoBehaviour {
private TrailRenderer tr_s;

	// Use this for initialization
	void Start () {
	tr_s=this.gameObject.GetComponent<TrailRenderer>();
        tr_s.startWidth=0.1f;
        tr_s.endWidth=0.3f;
        tr_s.material.color=Color.white;
        tr_s.time=20f;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
