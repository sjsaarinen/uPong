﻿using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {        
        GameManager.gm.addScore();
    }
}
