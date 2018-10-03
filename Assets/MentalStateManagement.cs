using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MentalStateManagement : MonoBehaviour {

    public Flowchart myFlowchart;

    //these variables have corresponding variables of the same name in the flowchart
    //because we will probably want to update, check, or reference them directly in the flowchart
    public int mentalStateScale;
    public bool midStateStatus;
    public bool lowStateStatus;
    public int manaCostOffenseCurrent;
    public float offenseAccuracyCurrent;
    public int offenseDamageCurrent;

    [Header("Variables not in flowchart")]
    //following variables are not in fungus; can be changed in the inspector

    [Header("Low Mental State Settings")]
    public int mentalStateLowThreshold;
    public int manaCostOffenseLowState;
    public float offenseAccuracyLowState;
    public int offenseDamageLowState;

    [Header("Middle Mental State Settings")]
    public int manaCostOffenseMidState;
    public float offenseAccuracyMidState;
    public int offenseDamageMidState;


    public void CheckMentalState(){
        //gets current variable values from the flowchart
        mentalStateScale = myFlowchart.GetIntegerVariable("mentalStateScale");

        //checks the mental state and updates bools in script
        if (mentalStateScale < mentalStateLowThreshold)
        {
            lowStateStatus = true;
            midStateStatus = false;
        }
        else{
            lowStateStatus = false;
            midStateStatus = true;
        }

        //updates flowchart variables to match script variables
        myFlowchart.SetBooleanVariable("midStateStatus",midStateStatus);
        myFlowchart.SetBooleanVariable("lowStateStatus", lowStateStatus);
    }



    public void CheckOffenseManaCost(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");

        //updates current mana cost of offensive spell in script
        if (midStateStatus == true)
        {
            manaCostOffenseCurrent = manaCostOffenseMidState;
        }
        else if (lowStateStatus == true){
            manaCostOffenseCurrent = manaCostOffenseLowState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetIntegerVariable("manaCostOffenseCurrent", manaCostOffenseCurrent);
    }



    public void CheckOffenseAccuracy(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");

        //updates current accuracy float in script
        if (midStateStatus == true)
        {
            offenseAccuracyCurrent = offenseAccuracyMidState;
        }
        else if(lowStateStatus == true){
            offenseAccuracyCurrent = offenseAccuracyLowState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("offenseAccuracyCurrent", offenseAccuracyCurrent);
    }




    public void CheckOffenseDamage(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");

        //updates current damage amount in script
        if (midStateStatus == true)
        {
            offenseDamageCurrent = offenseDamageMidState;
        }
        else if (lowStateStatus == true)
        {
            offenseDamageCurrent = offenseDamageLowState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetIntegerVariable("offenseDamageCurrent", offenseDamageCurrent);
        }
}
