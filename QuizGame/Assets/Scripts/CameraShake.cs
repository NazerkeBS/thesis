﻿using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Shake(0.4f, 0.5f));
    }


    private IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;
        while(elapsed < duration) {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed = elapsed + Time.deltaTime;

            yield return null;
        
        }
        transform.localPosition = originalPos;
    }
}
