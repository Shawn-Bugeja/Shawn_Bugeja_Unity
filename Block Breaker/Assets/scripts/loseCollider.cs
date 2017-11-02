﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseCollider : MonoBehaviour {

    public LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision Happened with " + collision.gameObject.name);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        myLevelManager.LoadLevel("Win");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}