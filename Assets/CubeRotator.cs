using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Transform targetCube;
    public float minX = 0f;
    public float maxX = 10f;

    void Update()
    {
        if (targetCube != null)
        {
            Cube(targetCube);
        }
    }

    public void Cube(Transform transformCube)
    {
        float posX = transformCube.position.x;
        float t = Mathf.InverseLerp(minX, maxX, posX);
        float targetRotationX = Mathf.Lerp(0f, 360f, t);
        transformCube.rotation = Quaternion.Euler(targetRotationX, 0, 0);
    }
}