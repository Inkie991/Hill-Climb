using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _carBody;
    [SerializeField] private Rigidbody2D _backTyre;

    [SerializeField] private Rigidbody2D _frontTyre;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private float _rotationSpeed = 300f;

    private float _moveInput;
    
    void Update()
    {
        Debug.Log(_moveInput);
    }

    private void FixedUpdate()
    {
        _frontTyre.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTyre.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carBody.AddTorque(_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }

    public void Gas()
    {
        _moveInput = 1;
    }

    public void Break()
    {
        _moveInput = -1;
    }

    public void NoInput()
    {
        _moveInput = 0;
    }
}
