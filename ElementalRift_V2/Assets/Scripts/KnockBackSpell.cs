﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBackSpell : MonoBehaviour {

    private Vector3 colRange;

    private Transform transform;
    private Vector3 location;
    private Collider[] objectsInRange;

    // Use this for initialization
    void Start()
    {
        print("Collider appearing");
        colRange.x = 1.0f;
        colRange.y = 1.0f;
        colRange.z = 10.0f;

        transform = GetComponent<Transform>();

        location = transform.position;

        objectsInRange = Physics.OverlapBox(location, colRange);
        foreach (Collider col in objectsInRange)
        {
            print("aaa");
            if (col.CompareTag("Enemy"))
            {
                Destroy(col.gameObject);
                print("Enemy present");
            }
        }
    }




}
