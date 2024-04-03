using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] protected float _jumpPower;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected Rigidbody2D _playerRigidbody;
    protected bool _isGrounded;
    protected bool _isJump;
    public void Jump()
    {
        _isJump = Input.GetKeyDown(KeyCode.W);
        
        if (_isJump && _isGrounded)
        {
            _playerRigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }
}
