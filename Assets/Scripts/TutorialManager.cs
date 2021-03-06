﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {

    public GameObject tutorialPanel;
    public GameObject playerHealthBar;
    public GameObject willpowerBar;
    public GameObject hopeMeter;
    public Text tbcMessage;

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

    public void ShowPCHealth(){
        playerHealthBar.gameObject.SetActive(true);
    }

    public void ShowWillpowerBar(){
        willpowerBar.gameObject.SetActive(true);
    }

    public void ShowHopeMeter(){
        hopeMeter.gameObject.SetActive(true);
    }

    public void HideHopeMeter()
    {
        hopeMeter.gameObject.SetActive(false);
    }

    public void HideWillpowerBar()
    {
        willpowerBar.gameObject.SetActive(false);
    }

    public void HidePCHealth()
    {
        playerHealthBar.gameObject.SetActive(false);
    }

    public void ShowTBCText()
    {
        tbcMessage.gameObject.SetActive(true);
    }
}
