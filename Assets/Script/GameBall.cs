﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBall : MonoBehaviour
{
    public void RandomlyTeleport()
    {
        gameObject.transform.position = new Vector3(
            GetRandomCoordinate(), Random.Range(0.5f, 2), GetRandomCoordinate());
    }

    private float GetRandomCoordinate()
    {
        var coordinate = Random.Range(-7, 7);
        while(coordinate > -1.5 && coordinate < 1.5)
        {
            coordinate = Random.Range(-7, 7);
        }
        return coordinate;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RandomlyTeleport();
        }
    }
}
