﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class mv1 : NetworkBehaviour {

    // Use this for initialization
    
    
        public float speed ;
        
        
        
    void Update()
    {

        if (!isLocalPlayer)
            return;
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        GetComponent<Rigidbody2D>().angularVelocity = 0;

        float input = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed * input);

    }
   

	}
	
	
