using System;
using System.Collections;
using System.Collections.Generic;
using TonNgoKhong.Scripts.ButtonGroup;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TabButton : AButton
{
    [SerializeField] private Button _button;

    private void OnValidate()
    {
        if (_button == null)
        {
            _button = GetComponent<Button>();
        }
    }

    public override void SetListener(UnityAction action)
    {
        _button.onClick.AddListener(action);
    }

    public override void OnChoose()
    {
    }

    public override void OnUnChoose()
    {
    }
}