using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SliderManagement : MonoBehaviour {

    public Flowchart myFlowchart;
    public Slider chimeraHealthSlider;

    private float chimeraHealthCurrent;
    private float chimeraHealthPrevious;


 
	void Start () {
		
	}
	

	void Update () {
		
	}


    public void UpdateChimeraHealthBar(){
        //this function must be called AFTER the flowchart has stored the chimera's "previous" health value 
        //AND THEN updated chimera's health based on attack damage

        //get values from flowchart
        chimeraHealthCurrent = myFlowchart.GetFloatVariable("chimeraHealthCurrent");
        chimeraHealthPrevious = myFlowchart.GetFloatVariable("chimeraHealthPrevious");

        //move the slider
        chimeraHealthSlider.value = Mathf.MoveTowards(chimeraHealthPrevious,chimeraHealthCurrent,100f);
    }

}
