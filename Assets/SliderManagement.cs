using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SliderManagement : MonoBehaviour {

    public Flowchart myFlowchart;
    public Slider chimeraHealthSlider;
    public Slider playerHealthSlider;
    public Slider manaSlider;

    private float chimeraHealthCurrent;
    private float chimeraHealthPrevious;
    private float playerHealthCurrent;
    private float playerHealthPrevious;
    private float manaCurrent;
    private float manaPrevious;


 
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



    public void UpdatePlayerHealthBar()
    {
        //this function must be called AFTER the flowchart has stored the player's "previous" health value 
        //AND THEN updated player's health based on healing effect OR chimera damage

        //get values from flowchart
        playerHealthCurrent = myFlowchart.GetFloatVariable("playerHealthCurrent");
        playerHealthPrevious = myFlowchart.GetFloatVariable("playerHealthPrevious");

        //move the slider
        playerHealthSlider.value = Mathf.MoveTowards(playerHealthPrevious, playerHealthCurrent, 100f);
    }




    public void UpdateManaBar()
    {
        //this function must be called AFTER the flowchart has stored the "previous" mana amount
        //AND THEN updated mana value based on spending or regaining mana

        //get values from flowchart
        manaCurrent = myFlowchart.GetFloatVariable("manaCurrent");
        manaPrevious = myFlowchart.GetFloatVariable("manaPrevious");

        //move the slider
        manaSlider.value = Mathf.MoveTowards(manaPrevious, manaCurrent, 100f);
    }
}
