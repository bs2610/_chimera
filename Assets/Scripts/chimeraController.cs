using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class chimeraController : MonoBehaviour {

    public Flowchart battleFlowchart;
    public string[] chimeraAttack = new string[] { "cShatter", "cPoison", "cFire", "cForce", "cHeal"};
	public int dragonHealth;
	public int lionHealth;
	public int ramHealth;
	public bool healingDone;
	public int lowStatePercent;

	//set a bool for whenever one of these have been used, but how how many rounds? 
	//essentially I'm trying to say not to do this? Well, lets leave it regular for now. 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 1))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("One");
            //just put them all in various blocks for now for the sake of expediency

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 3))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Two");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 4))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Three");

        }

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 5))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Four");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetFloatVariable("chimeraHealthCurrent") < 50) && (battleFlowchart.GetBooleanVariable("halfHealthDialogueDone") == false))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Chimera half health");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetFloatVariable("chimeraHealthCurrent") < 25) && (battleFlowchart.GetBooleanVariable("quarterHealthDialogueDone") == false))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Chimera quarter health");

        }
		else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && ((battleFlowchart.GetBooleanVariable("ultraLowStateStatus") == true)))
		{
			//later put in stipulations about what happens if one head dies-- that's the next biggest step. 
			battleFlowchart.StopAllBlocks();
			lowStatePercent = Random.Range (0, 2);
			if (lowStatePercent == 2) {
				battleFlowchart.ExecuteBlock ("player combat options");
			} else {

				battleFlowchart.ExecuteBlock (chimeraAttack [Random.Range (0, 4)]);
			}
		}

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true))
        {
			//later put in stipulations about what happens if one head dies-- that's the next biggest step. 
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock(chimeraAttack[Random.Range(0, 4)]);
        }

    }

	void chimeraHealChooser () {


		dragonHealth = GetComponent<StateTracker> ().myFlowchart.GetIntegerVariable("dragonHealthCurrent");
		lionHealth = GetComponent<StateTracker> ().myFlowchart.GetIntegerVariable("lionHealthCurrent");
		ramHealth = GetComponent<StateTracker> ().myFlowchart.GetIntegerVariable("ramHealthCurrent");

		if (dragonHealth < lionHealth && dragonHealth < ramHealth) {
			dragonHealth = dragonHealth + (20);
		} else if (lionHealth < dragonHealth && lionHealth < ramHealth){
			lionHealth = dragonHealth + (20);
		} else if (ramHealth < dragonHealth && ramHealth < lionHealth){
			ramHealth = dragonHealth + (20);
		}
	
	}
}
