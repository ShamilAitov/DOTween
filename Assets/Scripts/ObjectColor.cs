using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private float _duration = 3;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.green, _duration).SetLoops(-1, LoopType.Yoyo);
    }

}
