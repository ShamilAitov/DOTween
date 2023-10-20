using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementLength;
    [SerializeField] private float _numberSeconds;

    private void Start()
    {
        transform.DOMoveZ(_movementLength, _numberSeconds).SetLoops(-1,LoopType.Yoyo);
    }
}
