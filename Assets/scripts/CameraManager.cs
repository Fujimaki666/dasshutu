using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform[] cameraPositions;
    int currentIndex = 0;

    public void Start()
    {
        currentIndex = 0;
        SetCameraPosition(currentIndex);
    }
    public void TurnRight()
    {
        currentIndex++;
        if (currentIndex >= cameraPositions.Length)
        {
            currentIndex = 0;
        }
        SetCameraPosition(currentIndex);
    }

    public void TurnLeft()
    {
        currentIndex--;
        if (currentIndex <= -1)
        {
            currentIndex = cameraPositions.Length - 1;
        }

        SetCameraPosition(currentIndex);
    }

    void SetCameraPosition(int index)
    {
        Camera.main.transform.position = cameraPositions[index].position;
        Camera.main.transform.rotation = cameraPositions[index].rotation;
    }
}
