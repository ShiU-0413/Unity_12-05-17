using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour {
public GameObject go;
public GameObject starA;
public GameObject starB;
public GameObject starC;

Renderer Ar;
Renderer Br;
Renderer Cr;



private GameObject A;


	void Start () {
A=GameObject.Find("GameObject_Spin");
for (int i=0; i<30; ++i){
GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
go.transform.position = Random.onUnitSphere*1.5f;
go.transform.localScale = new Vector3(0.02f,0.02f,0.02f);
go.transform.parent = A.transform;
go.layer = 10;
}


starA = GameObject.Find("GreenStar");

Ar=starA.GetComponent<Renderer>();
Ar.material.color = Color.green;


starB = GameObject.Find("RedStar");

Br=starB.GetComponent<Renderer>();
Br.material.color = Color.red;



starC = GameObject.Find("BlueStar");

Cr=starC.GetComponent<Renderer>();
Cr.material.color = Color.blue;








	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

