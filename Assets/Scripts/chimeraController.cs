using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class chimeraController : MonoBehaviour {

    public Flowchart battleFlowchart;
    public string[] chimeraAttack = new string[5] { "cShatter", "cPoison", "cFire", "cHeal", "cForce"};
	public int dragonHealth;
	public int lionHealth;
	public int ramHealth;
	public bool healingDone;
	public int lowStateTurns;

	//set a bool for whenever one of these have been used, but how how many rounds? 
	//essentially I'm trying to say not to do this? Well, lets leave it regular for now. 
	// Use this for initialization
	void Start () {

		lowStateTurns = 0;
	}

    // Update is called once per frame
    void Update()
    {

        if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 3))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("One");
            //just put them all in various blocks for now for the sake of expediency

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 8))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Two");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 13))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Three");

        }

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 17))
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
			//battleFlowchart.StopAllBlocks();
			//lowStateTurns++;

			if ((battleFlowchart.GetIntegerVariable("ultraLowStateConsecutive") >= 4)) {
				battleFlowchart.StopAllBlocks();
				//battleFlowchart.GetIntegerVariable("ultraLowStateConsecutive") == 0;
				battleFlowchart.SetBooleanVariable("playerIsAttacking", false);
				battleFlowchart.ExecuteBlock ("player combat options");

			
			} else if ((battleFlowchart.GetIntegerVariable("ultraLowStateConsecutive") < 4)) {
//				battleFlowchart.StopAllBlocks();
				battleFlowchart.ExecuteBlock (chimeraAttack [Random.Range (0, 3)]);
			}
		}

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true))
        {
			//later put in stipulations about what happens if one head dies-- that's the next biggest step. 
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock(chimeraAttack[Random.Range(0, 5)]);
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
