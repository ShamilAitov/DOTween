using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{

    private Vector3 _degreeRotation;
    private float _numberSeconds = 3;

    void Start()
    {
        _degreeRotation = new Vector3(0, 360, 0);
        transform.DORotate(_degreeRotation, _numberSeconds, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1,LoopType.Restart); 
    }
}
