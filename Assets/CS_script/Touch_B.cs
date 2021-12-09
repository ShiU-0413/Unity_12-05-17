using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Touch_B : MonoBehaviour {

private GameObject RS;
Renderer Rr;
public GameObject star_r;
private Vector3 Pos_Rl;

protected virtual void CheckTouch()
{
if (Input.touchCount <= 0)
   {

   return;

   }

Touch touch =Input.GetTouch(0);
if(touch.phase == TouchPhase.Began)
   {

Pos_Rl = star_r.GetComponent<Transform>().transform.position;

GameObject RS = Instantiate(star_r,Pos_Rl,Quaternion.identity) as GameObject;


Rr=RS.GetComponent<Renderer>();
Rr.material.color = Color.blue;

   }


}

	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {

CheckTouch();
		
	}
}
