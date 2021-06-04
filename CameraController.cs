﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject followTarget;
	private Vector3 targetPos;
	public float cameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(followTarget.transform.position.x,transform.position.y, -10);
		transform.position = Vector3.Lerp(transform.position, targetPos,cameraSpeed * Time.deltaTime);
	}
 }

 