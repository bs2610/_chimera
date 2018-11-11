using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SliderManagement : MonoBehaviour {

    public Flowchart myFlowchart;
    public Slider chimeraHealthSlider;
    public Text chimeraHealthText;
    public Slider ramHealthSlider;
    public Text ramHealthText;
    public Slider dragonHealthSlider;
    public Text dragonHealthText;
    public Slider playerHealthSlider;
    public Text playerHealthText;
    public Slider manaSlider;
    public Text manaText;
    public Text mentalStateText;

    private float chimeraHealthCurrent;
    private float chimeraHealthPrevious;
    private float ramHealthPrevious;
    private float ramHealthCurrent;
    private float dragonHealthPrevious;
    private float dragonHealthCurrent;
    private float playerHealthCurrent;
    private float playerHealthPrevious;
    private float manaCurrent;
    private float manaPrevious;
    private float mentalStateScale;
    private float mentalStateScalePrevious;



    private void Update()
    {
        if (myFlowchart.GetBooleanVariable("lowStateStatus") ==true)
        {
            mentalStateText.text = myFlowchart.GetStringVariable("lowStateName");
        }
        else if (myFlowchart.GetBooleanVariable("hiStateStatus") == true)
        {
            mentalStateText.text = myFlowchart.GetStringVariable("hiStateName");
        }
        else if (myFlowchart.GetBooleanVariable("midStateStatus") == true)
        {
            mentalStateText.text = myFlowchart.GetStringVariable("midStateName");
        }
        else if(myFlowchart.GetBooleanVariable("ultraHighStateStatus") == true){
            mentalStateText.text = "Extremely Careless";
        }
        else if (myFlowchart.GetBooleanVariable("ultraLowStateStatus") == true)
        {
            mentalStateText.text = "Extremely Disheartened";
        }
    }

    public void UpdateChimeraHealthBar(){
        //this function must be called AFTER the flowchart has stored the chimera's "previous" health value 
        //AND THEN updated chimera's health based on attack damage

        //get values from flowchart
        chimeraHealthCurrent = myFlowchart.GetFloatVariable("chimeraHealthCurrent");
        chimeraHealthPrevious = myFlowchart.GetFloatVariable("chimeraHealthPrevious");

        //move the slider
        chimeraHealthSlider.value = Mathf.MoveTowards(chimeraHealthPrevious,chimeraHealthCurrent,100f);

        //update the text
        chimeraHealthText.text = chimeraHealthCurrent + "/" + myFlowchart.GetFloatVariable("chimeraHealthMax");
    }

    public void UpdateRamHealthBar()
    {
        //this function must be called AFTER the flowchart has stored the ram's "previous" health value 
        //AND THEN updated ram's health based on attack damage

        //get values from flowchart
        ramHealthCurrent = myFlowchart.GetFloatVariable("ramHealthCurrent");
        ramHealthPrevious = myFlowchart.GetFloatVariable("ramHealthPrevious");

        //move the slider
        ramHealthSlider.value = Mathf.MoveTowards(ramHealthPrevious, ramHealthCurrent, 100f);

        //update the text
        ramHealthText.text = ramHealthCurrent + "/" + myFlowchart.GetFloatVariable("ramHealthMax");
    }


    public void UpdateDragonHealthBar()
    {
        //this function must be called AFTER the flowchart has stored the ram's "previous" health value 
        //AND THEN updated ram's health based on attack damage

        //get values from flowchart
        dragonHealthCurrent = myFlowchart.GetFloatVariable("dragonHealthCurrent");
        dragonHealthPrevious = myFlowchart.GetFloatVariable("dragonHealthPrevious");

        //move the slider
        dragonHealthSlider.value = Mathf.MoveTowards(dragonHealthPrevious, dragonHealthCurrent, 100f);

        //update the text
        dragonHealthText.text = dragonHealthCurrent + "/" + myFlowchart.GetFloatVariable("dragonHealthMax");
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

        //update the text
        playerHealthText.text = playerHealthCurrent + "/" + myFlowchart.GetFloatVariable("playerHealthMax");
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

        //update the text
        manaText.text = manaCurrent + "/" + myFlowchart.GetFloatVariable("manaMax");
    }


}
