using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Touch_G : MonoBehaviour {

private GameObject GS;
Renderer Gr;
public GameObject star_g;
private Vector3 Pos_Gl;

protected virtual void CheckTouch()
{
if (Input.touchCount <= 0)
   {

   return;

   }

Touch touch =Input.GetTouch(0);
if(touch.phase == TouchPhase.Began)
   {

Pos_Gl = star_g.GetComponent<Transform>().transform.position;

GameObject GS = Instantiate(star_g,Pos_Gl,Quaternion.identity) as GameObject;


Gr=GS.GetComponent<Renderer>();
Gr.material.color = Color.green;

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
