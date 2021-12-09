using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro : MonoBehaviour {
public static Quaternion gyro_value;


public static Quaternion get_gyro(){

       return gyro_value;

}


	// Use this for initialization
	void Start () {
Input.gyro.enabled = true;		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180f, Vector3.forward); 

gyro_value = Input.gyro.attitude;		
	}
}