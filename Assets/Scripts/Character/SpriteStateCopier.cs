using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteStateCopier : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private SpriteRenderer targetRenderer;

    [SerializeField] private Vector3 posOffset;
    [SerializeField] private Quaternion rotOffset;

    private SpriteRenderer ownRenderer;

    private void Start()
    {
        ownRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        ownRenderer.sprite = targetRenderer.sprite;
        transform.position = targetTransform.position + posOffset;
        transform.rotation = Quaternion.Euler(targetTransform.eulerAngles.x + rotOffset.x,
            targetTransform.eulerAngles.y + rotOffset.y, targetTransform.eulerAngles.z + rotOffset.z);
    }
}
