using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class reverseStrings : MonoBehaviour {


	public Flowchart rFlowchart;

//	public string cReversed;
//	public string yReversed;
//	public string pReversed;
//
	public StringVar testvar;
	public char [] cCharArray = new char[4];



	// Use this for initialization

	public void Awake() {
		//char [] cCharArray;
		Debug.Log("awake");

	}



	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void cReverse (){
		
		cCharArray = rFlowchart.GetStringVariable ("cCode").ToCharArray ();

		for(int i=0;i<4;i++){
			//char cReversed = cCharArray [(2)];
			rFlowchart.SetStringVariable ("cReversed",((cCharArray [(3)].ToString()) + (cCharArray [(2)].ToString()) + (cCharArray [(1)].ToString()) + (cCharArray [(0)].ToString())));
			Debug.Log (rFlowchart.GetStringVariable ("cReversed"));
	
			// ("cReversed") = "resazraer";
		}

	
	}
}
