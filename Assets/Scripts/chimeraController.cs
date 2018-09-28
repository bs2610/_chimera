using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class chimeraController : MonoBehaviour {

    public Flowchart battleFlowchart;
    public string[] chimeraAttack = new string[] { "cFire", "cShatter", "cPoison" };

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 4))
        {

            battleFlowchart.ExecuteBlock("One");
            //just put them all in various blocks for now for the sake of expediency

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 6))
        {

            battleFlowchart.ExecuteBlock("Two");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 7))
        {

            battleFlowchart.ExecuteBlock("Three");

        }

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true))
        {
            battleFlowchart.ExecuteBlock(chimeraAttack[Random.Range(0, 2)]);
        }

    }
}
