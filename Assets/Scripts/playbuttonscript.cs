﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbuttonscript : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
    
    private void OnMouseDown()
    {
        SceneManager.LoadScene("BossFight");
    }


    // Update is called once per frame
    void Update () {

	}
}