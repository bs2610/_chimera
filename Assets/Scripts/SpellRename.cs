using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SpellRename : MonoBehaviour {

   private string spellName;
    private string firstChar;
    private string secondChar;
    private string thirdChar;
    public Flowchart myFlowchart;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void RenameSpell(){
        firstChar = myFlowchart.GetStringVariable("firstChar");
        secondChar = myFlowchart.GetStringVariable("secondChar");
        thirdChar = myFlowchart.GetStringVariable("thirdChar");
        spellName = firstChar + " " + secondChar + " " + thirdChar;
        myFlowchart.SetStringVariable("spellName",spellName);
    }
}
