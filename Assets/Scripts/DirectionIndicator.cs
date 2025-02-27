using UnityEngine;
using Unity.Cinemachine;

public class DirectionIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;
    [SerializeField] private Transform orientation;

    void Update()
    {
        if (freeLookCamera == null || orientation == null) return;

        Vector3 cameraForward = freeLookCamera.transform.forward;
        cameraForward.y = 0; 
        orientation.forward = cameraForward.normalized;
    }
}

