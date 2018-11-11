using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ProgressMeters : MonoBehaviour {
    public float hope;
	public uint totalHope;
	public float percentHope;
    public Flowchart myFlowchart;

	//public RectTransform mentalStateBar;
	public Image mentalStateMeter;
	public RectTransform needle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get hope level from flowchart variable
        hope = myFlowchart.GetFloatVariable("mentalStateScale");
 
        //cap hope
		if(hope>totalHope/2){
			hope=totalHope/2;
		}

		//calculate hope percentage
		percentHope=(float)hope/totalHope;

		//circular Mental State meter
		mentalStateMeter.fillAmount=percentHope;
		
		// Have the tip of the needle follow the current value of hope. 
		float needleAngle = percentHope*360 - 90;
		needle.localEulerAngles = new Vector3(0, 0, -needleAngle);

	}
}
