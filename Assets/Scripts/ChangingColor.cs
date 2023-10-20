using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangingColor : MonoBehaviour
{
    [SerializeField] private float _duration;

    private SpriteRenderer _spriteRenderer;
    

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.green, _duration).SetLoops(-1, LoopType.Yoyo);
    }

}
