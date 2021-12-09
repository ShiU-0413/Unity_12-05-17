using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kiroku : MonoBehaviour {

private GameObject RS; //クリプト内で生成する星
private GameObject GS;
private GameObject BS;

Renderer Rr;　//星の色
Renderer Gr;
Renderer Br;

public GameObject star_r;　　//シーン内にある星
public GameObject star_g;
public GameObject star_b;

public GameObject tog_r, tog_g, tog_b, bottun_kiroku;


//star_r = GameObject.Find("RedStar");	
//private GameObject star_g = GameObject.Find("GreenStar");
//private GameObject star_b = GameObject.Find("BlueStar");



//private float Pos_Rx, Pos_Gx, Pos_Bx, Pos_Ry, Pos_Gy, Pos_By, Pos_Rz, Pos_Gz, Pos_Bz;
private Vector3 Pos_Rl, Pos_Gl, Pos_Bl;

	// Use this for initialization
	//void Start () {


//Pos_Rx = star_r.GetComponent<Transform>().transform.Position.x;

//Pos_Rl = star_r.GetComponent<Transform>().transform.position;
//Pos_Rw = transform.TransformPoint(Pos_Rl);

//Pos_Gx = star_g.GetComponent<Transform>().transform.Position.x;
//Pos_Bx = star_b.GetComponent<Transform>().transform.Position.x;

//Pos_Ry = star_r.GetComponent<Transform>().transform.Position.y;
//Pos_Gy = star_g.GetComponent<Transform>().transform.Position.y;
//Pos_By = star_b.GetComponent<Transform>().transform.Position.y;

//Pos_Rz = star_r.GetComponent<Transform>().transform.Position.z;
//Pos_Gz = star_g.GetComponent<Transform>().transform.Position.z;
//Pos_Bz = star_b.GetComponent<Transform>().transform.Position.z;


//}

//public void Awake(){

//GameObject RS = GameObject.CreatePrimitive(PrimitiveType.Sphere);
//RS.transform.localPosition = new Vector3(Pos_Rx,Pos_Ry,Pos_Rz);
//RS.transform.localScale = new Vector3(0.05f,0.05f,0.05f);

//Rr=RS.GetComponent<Renderer>();
//Rr.material.color = Color.red;

//GameObject GS = GameObject.CreatePrimitive(PrimitiveType.Sphere);
//GS.transform.localPosition = new Vector3(Pos_Gx,Pos_Gy,Pos_Gz);
//GS.transform.localScale = new Vector3(0.05f,0.05f,0.05f);

//Gr=GS.GetComponent<Renderer>();
//Gr.material.color = Color.green;

//GameObject BS = GameObject.CreatePrimitive(PrimitiveType.Sphere);
//BS.transform.localPosition = new Vector3(Pos_Bx,Pos_By,Pos_Bz);
//BS.transform.localScale = new Vector3(0.05f,0.05f,0.05f);

//Br=BS.GetComponent<Renderer>();
//Br.material.color = Color.blue;

//}
	// Update is called once per frame
	//void Update () {
	//}

public void OnClick(){

Pos_Rl = star_r.GetComponent<Transform>().transform.position;
//Pos_Rw = transform.TransformPoint(Pos_Rl);

Pos_Gl = star_g.GetComponent<Transform>().transform.position;

Pos_Bl = star_b.GetComponent<Transform>().transform.position;

if (tog_r.GetComponent<Toggle>().isOn){
//GameObject RS = Instantiate(star_r) as GameObject;
//GameObject RS = Instantiate(star_r,new Vector3(Pos_Rx,Pos_Ry,Pos_Rz)) as GameObject;

GameObject RS = Instantiate(star_r,Pos_Rl,Quaternion.identity) as GameObject;


Rr=RS.GetComponent<Renderer>();
Rr.material.color = Color.red;	

}

if (tog_g.GetComponent<Toggle>().isOn){

//GameObject GS = Instantiate(star_g) as GameObject;


GameObject GS = Instantiate(star_g,Pos_Gl,Quaternion.identity) as GameObject;


Gr=GS.GetComponent<Renderer>();
Gr.material.color = Color.green;

}

if (tog_b.GetComponent<Toggle>().isOn){

//GameObject BS = Instantiate(star_b) as GameObject;


GameObject BS = Instantiate(star_b,Pos_Bl,Quaternion.identity) as GameObject;


Br=BS.GetComponent<Renderer>();
Br.material.color = Color.blue;

}

}
}
