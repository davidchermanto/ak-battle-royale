using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionSharer : MonoBehaviour
{
    public static CameraPositionSharer Instance;

    public Vector3 currentRotation;
    public Vector3 currentPosition;

    [SerializeField] private Camera mainCamera;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = mainCamera.transform.position;
        currentRotation = mainCamera.transform.localEulerAngles;
    }
}
