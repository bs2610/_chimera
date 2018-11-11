using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowExtremeBehavior : MonoBehaviour {

	public int chimeraBlockNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void lowestStatePicker () {
	
		//randomly picks certain chimera behaviors
		//this line to put them back is temporary
		Debug.Log("lowest state on");
		GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("player combat options");
	}


}
