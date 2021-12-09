using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {
private Compass compass;
private GUIStyle labelStyle;
	// Use this for initialization
	void Start () {
		this.labelStyle = new GUIStyle();
	    this.labelStyle.fontSize = Screen.height / 22;
	    this.labelStyle.normal.textColor = Color.white;

	Input.compass.enabled = true;	
	}
	
	// Update is called once per frame
	void Update () {
	this.compass = Input.compass;	
	}

	void OnGUI()
	{
	float x = Screen.width/10;
	float y =0;
	float w = Screen.width*8/10;
	float h = Screen.height/20;

	for (int i =0; i<3; i++)
	{
	y = Screen.height/10+h*i;
	string text = string.Empty;

	switch (i)
	{
		case 0:
			text=string.Format("comps-X:{0}", this.compass.rawVector.x);
			break;
		case 1:
			text=string.Format("comps-Y:{0}", this.compass.rawVector.y);
			break;
		case 2:
			text=string.Format("comps-Z:{0}", this.compass.rawVector.z);
			break;
		default:
			throw new System.InvalidOperationException();
	}
	GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
	}
	}
}
