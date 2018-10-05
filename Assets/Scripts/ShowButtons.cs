using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtons : MonoBehaviour {

    public GameObject quitButton;
    public GameObject retryButton;

    public void ShowQuitButton()
    {
        quitButton.SetActive(true);
    }

    public void ShowRetryButton()
    {
        retryButton.SetActive(true);
    }
}
