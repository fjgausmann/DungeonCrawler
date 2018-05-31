using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverViewScript : MonoBehaviour {
	private GameObject MainCamera;
	private GameObject OverViewCamera;
	private MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
	private OverViewCamera = GameObject.FindGameObjectWithTag ("OverViewCamera");
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (MainCamera.activeInHierarchy)
		{
			if (Input.GetKeyDown ("o")) 
			{
				Time.timeScale = 0;
				MainCamera.SetActive(false);
				OverViewCamera.SetActive(true);
			}
		}

		else 
		{
			if(Input.GetKeyDown("o"))
			{ 
				Time.timeScale = 1;
				MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
				MainCamera.SetActive(true);
				OverViewCamera = GameObject.FindGameObjectWithTag ("OverViewCamera");
				OverViewCamera.SetActive(false);
			}
		}
	}
}
