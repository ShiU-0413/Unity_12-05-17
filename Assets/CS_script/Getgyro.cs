using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Getgyro : MonoBehaviour {
private Quaternion scene1_gyro;
private Quaternion inputgyro;




	// Use this for initialization
	void Start () {

scene1_gyro = gyro.get_gyro();
Input.gyro.enabled = true;

   
	}
	
	// Update is called once per frame
	void Update () {




        inputgyro = Quaternion.AngleAxis(136f, Vector3.right) * Quaternion.Inverse(scene1_gyro) * Input.gyro.attitude * Quaternion.AngleAxis(-180f, Vector3.back); 
transform.rotation = inputgyro;

	}
}
