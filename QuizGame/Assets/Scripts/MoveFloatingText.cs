﻿using UnityEngine;

public class MoveFloatingText : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,Time.deltaTime * 50));
    }
}
