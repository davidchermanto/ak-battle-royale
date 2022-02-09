using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpriteLock : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRenderer.transform.rotation = Quaternion.Euler(0, CameraPositionSharer.Instance.currentRotation.y, 0);
    }
}
