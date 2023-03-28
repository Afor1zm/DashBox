using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;
    private PlayerInputActions _playerInput;
    

    private void Awake()
    {        
        _playerInput = new PlayerInputActions();
        _playerInput.KeyBoardMap.Jump.performed += Plasyerjumping;
        BarrierCollisionDetection.OnCollided += DisableControls;
    }
    
    private void OnEnable()
    {
        _playerInput.KeyBoardMap.Enable();
    }  

    private void Plasyerjumping(InputAction.CallbackContext context)
    {        
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce);        
    }
    private void DisableControls()
    {
        _playerInput.KeyBoardMap.Disable();
    }
}
