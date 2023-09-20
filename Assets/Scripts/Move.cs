using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    private float _movementLength = 7f;
    private float _numberSeconds = 3f;

    void Start()
    {
        transform.DOMoveZ(_movementLength, _numberSeconds).SetLoops(-1,LoopType.Yoyo);
    }
}
