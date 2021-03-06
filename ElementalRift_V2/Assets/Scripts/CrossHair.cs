﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    Texture2D image;
    [SerializeField]
    int size;
    [SerializeField]
    float maxAngle;
    [SerializeField]
    float minAngle;

    public GameObject cameraLookTarget;

    float lookHeight;

    
    public void LookHeight(float value)
    {
        lookHeight += value;

        if (lookHeight > maxAngle || lookHeight < minAngle)
            lookHeight -= value;
    }

    private void OnGUI()
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.y = Screen.height - screenPosition.y;
       
        GUI.DrawTexture(new Rect(screenPosition.x, screenPosition.y - lookHeight, size, size), image);
    }
}
