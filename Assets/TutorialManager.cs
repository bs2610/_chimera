using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {

    public GameObject tutorialPanel;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ShowTutorialPanel(){
        tutorialPanel.gameObject.SetActive(true);
    }

    public void HideTutorialPanel(){
        tutorialPanel.gameObject.SetActive(false);
    }
}
