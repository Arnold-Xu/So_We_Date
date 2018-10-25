﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    private bool isShown=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMenu();
        }
        
	}

    public void ShowMenu()
    {
        if (!isShown)
        {
            GetComponent<Animator>().SetBool("IsDisplayed", true);
            isShown = true;
            DialogManager.Instance.isDisabled = true;
        }
        else
        {
            GetComponent<Animator>().SetBool("IsDisplayed", false);
            isShown = false;
            DialogManager.Instance.isDisabled = false;
        }
    }


}
