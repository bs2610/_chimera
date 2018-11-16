using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TrackMetrics: MonoBehaviour {

    public Flowchart myFlowchart;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //at the start of every Player turn, call this function
    //currently kind of bugged because I call it every time the player looks at their options for their turn
    //in the "player combat options" block
    //so this will happen more than once per player turn if they go back to this menu because they changed their mind
    public void TrackingMetrics(){
        MetricManagerScript.instance.LogMentalStateAtTurnStart("Mental State Value",myFlowchart.GetFloatVariable("mentalStateScale"));
        MetricManagerScript.instance.LogPlayerHealthAtTurnStart("Player Health", myFlowchart.GetFloatVariable("playerHealthCurrent"));
        MetricManagerScript.instance.LogChimeraHealthAtTurnStart("Lion Health",myFlowchart.GetFloatVariable("chimeraHealthCurrent"));
        MetricManagerScript.instance.LogRamHealthAtTurnStart("Ram Health", myFlowchart.GetFloatVariable("ramHealthCurrent"));
        MetricManagerScript.instance.LogDragonHealthAtTurnStart("Dragon Health", myFlowchart.GetFloatVariable("dragonHealthCurrent"));
        MetricManagerScript.instance.LogTotalEnemyHealthAtTurnStart("Total Chimera Health", myFlowchart.GetFloatVariable("totalChimeraHealth"));
    }
}
