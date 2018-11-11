using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class IntroChimeraController : MonoBehaviour {

    public Flowchart battleFlowchart;
    public string[] chimeraAttack = new string[] { "cShatter", "cPoison", "cFire"};

    // Use this for initialization
    void Start () {
        
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
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 5))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Two");

        }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 6))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Three");

        }

        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 7))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock("Four");

        }
       // else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true) && (battleFlowchart.GetIntegerVariable("playerSpellNumber") == 8))
      //  {
      //      battleFlowchart.StopAllBlocks();
      //      battleFlowchart.ExecuteBlock("chimera kills you");
      //  }
        else if ((battleFlowchart.GetBooleanVariable("playerIsAttacking") == true))
        {
            battleFlowchart.StopAllBlocks();
            battleFlowchart.ExecuteBlock(chimeraAttack[Random.Range(0, 3)]);
        }

    }
}
