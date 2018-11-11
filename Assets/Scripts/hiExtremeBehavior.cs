using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiExtremeBehavior : MonoBehaviour {

	public int blockNumber;
	public int targetSelector;

	//for this, random range for picking out a block-- one of the ones there, which would either be one of the fighting options or the regular menu
	//this seems easy enough, right? 
	//check to see when this gets turned off but we can come back to that
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void highestStatePicker (){
	
		blockNumber = Random.Range (0, 10);
		if (blockNumber <= 4) {
			//goes for melee attack
			GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("melee");
		} else if (blockNumber > 4 && blockNumber <= 8) {
			targetSelector = (Random.Range(0,2));
				if (targetSelector == 0){
					//randomly picks someone to attack
					GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("offense spell accuracy check RAM");
				} else if (targetSelector == 1){
					GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("offense spell accuracy check DRAGON");
				} else if (targetSelector == 2){
					GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("offense spell accuracy check LION");
				}
		} else if (blockNumber > 8 && blockNumber <= 10) {
					//general player combat options 
			GetComponent<StateTracker> ().myFlowchart.ExecuteBlock ("player combat options");
		}
	}

}
