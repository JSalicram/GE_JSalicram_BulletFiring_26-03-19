using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScan : MonoBehaviour {
    public Vector2 originPos;
    public float detectRadius;
    Collider2D[] targetArray;
    public LayerMask targetLayer;

    private void Awake()
    {
        originPos = this.transform.position;
        detectRadius = 20f;

        targetLayer = LayerMask.GetMask("Target");
    }

    public void DetectTargets()
    {
        targetArray = Physics2D.OverlapCircleAll(originPos, detectRadius, targetLayer);

        for(int i = 0; i < targetArray.Length; i++)
        {
            Destroy(targetArray[i].gameObject);
        }
    }
}
