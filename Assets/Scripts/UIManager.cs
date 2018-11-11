using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UIManager : MonoBehaviour {


	public InputField myInputField;
	public InputField cInputfield;
	public InputField frontInputfield;
	public Font runeFont;
	public Text textEntered; 
	public Text cTextEntered;
	public Text frontEntered;
	public Flowchart mainFlowchart;
	//public string cCodeEntered = frontInputfield.text;




    void ShowInputField(){

		myInputField.gameObject.SetActive (true);
		OnSubmit ();
    }





    void HideInputField()
    {
		myInputField.gameObject.SetActive (false);
    }





	//fonts for input field
	void runeFontOn()
	{
		cInputfield.gameObject.SetActive (true);
		textEntered.text = "/0";
		cTextEntered.font = runeFont;
		cInputfield.characterLimit = 4; 
		OnSubmit ();

	}




	void normalFont()
	{
		cInputfield.gameObject.SetActive (false);
		
	}



	//temporary


	void frontEnter()
	{
		frontInputfield.text = "";
		frontInputfield.gameObject.SetActive (true);


	}





	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			Debug.Log ("enetered");
			if (mainFlowchart.GetBooleanVariable ("cBoolean") == true) {
				frontEntered.font = runeFont;
				frontInputfield.characterLimit = 4; 
				string cCodeEntered = frontInputfield.text;


				if (cCodeEntered != mainFlowchart.GetStringVariable("cCode")){
					mainFlowchart.ExecuteBlock ("failCode");
					frontInputfield.text = "";

				} else if (cCodeEntered == mainFlowchart.GetStringVariable("cCode")){
					mainFlowchart.ExecuteBlock ("succCode");
					frontInputfield.text = "";

					} 


					
			}

			else if ((mainFlowchart.GetBooleanVariable ("tempBoolean") == true) ) {
				
				if (Input.GetKeyDown (KeyCode.Return)) {
					string cCodeEntered2 = frontInputfield.text;
					if (cCodeEntered2 != mainFlowchart.GetStringVariable ("cReversed")) {
						mainFlowchart.ExecuteBlock ("failReverse");
						frontInputfield.text = "";

					} else if (cCodeEntered2 == mainFlowchart.GetStringVariable ("cReversed")) {
						mainFlowchart.ExecuteBlock ("Candle Repetition");
						frontInputfield.text = "";

					}
				}

			}
		}
	}






	void OnSubmit(){
	
		if (mainFlowchart.GetBooleanVariable ("intBoolean") == true) {
			if ((Input.GetKeyDown(KeyCode.Return) && (textEntered.text.Length > 0 ))){
				mainFlowchart.ExecuteBlock ("intention entered");
			}
		}



		if (mainFlowchart.GetBooleanVariable ("cBoolean") == true) {

			if ((Input.GetKeyDown(KeyCode.Return) && (textEntered.text.Length == 4 ))){
				string candleBlockPicked = (mainFlowchart.GetComponent<blockArrays>().candleBlocks[Random.Range(0,1)]);
				mainFlowchart.ExecuteBlock (candleBlockPicked);
			}

		}

	
	}




}
