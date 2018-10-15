using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MentalStateManagement : MonoBehaviour {

    public Flowchart myFlowchart;

    //these variables have corresponding variables of the same name in the flowchart
    //because we will probably want to update, check, or reference them directly in the flowchart
    //i'm pretty sure it's fine that they're private because they are like local "copies" of the flowchart variables
    private float mentalStateScale;
    private bool midStateStatus;
    private bool lowStateStatus;
    private bool hiStateStatus;
    private float manaCostOffenseCurrent;
    private float offenseAccuracyCurrent;
    private float offenseDamageCurrent;
    private float manaCostDefenseCurrent;
    private float manaCostHealCurrent;
    private float healEffectCurrent;
    private float defenseEffectCurrent;

    [Header("Variables not in flowchart")]
    //following variables are not in fungus flowchart; can be changed in the inspector

    [Header("Low Mental State Settings")]
    public float mentalStateLowThreshold;
    public float manaCostOffenseLowState;
    public float offenseAccuracyLowState;
    public float offenseDamageLowState;
    public float manaCostDefenseLowState;
    public float defenseEffectLowState; //decrease chimera attack by this percentage
    public float manaCostHealLowState;
    public float healEffectLowState;



    [Header("Middle Mental State Settings")]
    public float manaCostOffenseMidState;
    public float offenseAccuracyMidState;
    public float offenseDamageMidState;
    public float manaCostDefenseMidState;
    public float defenseEffectMidState; //decrease chimera attack by this percentage
    public float manaCostHealMidState;
    public float healEffectMidState;


    [Header("High Mental State Settings")]
    public float mentalStateHiThreshold;
    public float manaCostOffenseHiState;
    public float offenseAccuracyHiState;
    public float offenseDamageHiState;
    public float manaCostDefenseHiState;
    public float defenseEffectHiState; //decrease chimera attack by this percentage
    public float manaCostHealHiState;
    public float healEffectHiState;


    public void CheckMentalState(){
        //gets current variable values from the flowchart
        mentalStateScale = myFlowchart.GetFloatVariable("mentalStateScale");

        //checks the mental state and updates bools in script
        if (mentalStateScale < mentalStateLowThreshold)
        {
            lowStateStatus = true;
            midStateStatus = false;
            hiStateStatus = false;
        }
        else if(mentalStateScale > mentalStateHiThreshold){
            lowStateStatus = false;
            midStateStatus = false;
            hiStateStatus = true;
        }
        else{
            lowStateStatus = false;
            midStateStatus = true;
            hiStateStatus = false;
        }

        //updates flowchart variables to match script variables
        myFlowchart.SetBooleanVariable("midStateStatus",midStateStatus);
        myFlowchart.SetBooleanVariable("lowStateStatus", lowStateStatus);
        myFlowchart.SetBooleanVariable("hiStateStatus", hiStateStatus);
    }





    public void CheckOffenseManaCost(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current mana cost of offensive spell in script
        if (midStateStatus == true)
        {
            manaCostOffenseCurrent = manaCostOffenseMidState;
        }
        else if (lowStateStatus == true){
            manaCostOffenseCurrent = manaCostOffenseLowState;
        }
        else if(hiStateStatus == true){
            manaCostOffenseCurrent = manaCostOffenseHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("manaCostOffenseCurrent", manaCostOffenseCurrent);
    }



    public void CheckOffenseAccuracy(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current accuracy float in script
        if (midStateStatus == true)
        {
            offenseAccuracyCurrent = offenseAccuracyMidState;
        }
        else if (lowStateStatus == true)
        {
            offenseAccuracyCurrent = offenseAccuracyLowState;
        }
        else if (hiStateStatus == true)
        {
            offenseAccuracyCurrent = offenseAccuracyHiState;

        }

            //updates flowchart variable to match script variable
            myFlowchart.SetFloatVariable("offenseAccuracyCurrent", offenseAccuracyCurrent);
    }




    public void CheckOffenseDamage(){
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current damage amount in script
        if (midStateStatus == true)
        {
            offenseDamageCurrent = offenseDamageMidState;
        }
        else if (lowStateStatus == true)
        {
            offenseDamageCurrent = offenseDamageLowState;
        }
        else if (hiStateStatus == true){
            offenseDamageCurrent = offenseDamageHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("offenseDamageCurrent", offenseDamageCurrent);
        }



    public void CheckDefenseManaCost()
    {
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current mana cost of defensive spell in script
        if (midStateStatus == true)
        {
            manaCostDefenseCurrent = manaCostDefenseMidState;
        }
        else if (lowStateStatus == true)
        {
            manaCostDefenseCurrent = manaCostDefenseLowState;
        }
        else if (hiStateStatus == true)
        {
            manaCostDefenseCurrent = manaCostDefenseHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("manaCostDefenseCurrent", manaCostDefenseCurrent);
    }





    public void CheckDefenseEffect()
    {
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current accuracy float in script
        if (midStateStatus == true)
        {
            defenseEffectCurrent = defenseEffectMidState;
        }
        else if (lowStateStatus == true)
        {
            defenseEffectCurrent = defenseEffectLowState;
        }
        else if (hiStateStatus == true)
        {
            defenseEffectCurrent = defenseEffectHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("defenseEffectCurrent", defenseEffectCurrent);
    }






    public void CheckHealManaCost()
    {
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current mana cost of defensive spell in script
        if (midStateStatus == true)
        {
            manaCostHealCurrent = manaCostHealMidState;
        }
        else if (lowStateStatus == true)
        {
            manaCostHealCurrent = manaCostHealLowState;
        }
        else if (hiStateStatus == true)
        {
            manaCostHealCurrent = manaCostHealHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("manaCostHealCurrent", manaCostHealCurrent);
    }




    public void CheckHealEffect()
    {
        //MUST RUN FUNCTION CheckMentalState() FIRST
        //checks flowchart for current mental state
        midStateStatus = myFlowchart.GetBooleanVariable("midStateStatus");
        lowStateStatus = myFlowchart.GetBooleanVariable("lowStateStatus");
        hiStateStatus = myFlowchart.GetBooleanVariable("hiStateStatus");

        //updates current damage amount in script
        if (midStateStatus == true)
        {
            healEffectCurrent = healEffectMidState;
        }
        else if (lowStateStatus == true)
        {
            healEffectCurrent = healEffectLowState;
        }
        else if (hiStateStatus == true)
        {
            healEffectCurrent = healEffectHiState;
        }

        //updates flowchart variable to match script variable
        myFlowchart.SetFloatVariable("healEffectCurrent", healEffectCurrent);
    }




}
