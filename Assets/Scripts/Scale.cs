using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _numberSeconds;

    private Vector3 _originalScale;
    private Vector3 _scaleTo;
    private float _zoomIn = 2f;

    private void Start()
    {
        _originalScale = transform.localScale;
        _scaleTo = _originalScale * _zoomIn;

        transform.DOScale(_scaleTo, _numberSeconds).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
