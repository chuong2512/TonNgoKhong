using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCollider : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _collider;

    private void Start()
    {
        RefreshCollider();
    }

    public void RefreshCollider()
    {
        _collider.radius = PlayerManager.Instance.CurrentStatus.Magnet;
    }
}