using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SequenceTextChanges : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(0, _text.DOText("������� �����", 2));
        sequence.Insert(3, _text.DOText("������� �����", 3).SetRelative());
        sequence.Insert(6, _text.DOText("������� �����", 2, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);

    }

}
