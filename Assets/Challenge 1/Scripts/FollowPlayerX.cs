﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(20, 0 , 0);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
