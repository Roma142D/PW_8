using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _groundCheckDistance;
    private bool _isGrounded;
    private bool _isJump;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private LayerMask _groundMask;
    
    private void Jump()
    {
        _playerRigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
    }
    private void Move()
    {
        var _direction = Input.GetAxis("Horizontal");
        _playerRigidbody.velocity = new Vector2(_moveSpeed * _direction, _playerRigidbody.velocity.y);
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.Raycast(_playerRigidbody.position, Vector2.down, _groundCheckDistance, _groundMask);
        Debug.DrawLine(_playerRigidbody.position, _playerRigidbody.position + Vector2.down * _groundCheckDistance, Color.red);
    }
    private void Update()
    {
        _isJump = Input.GetKeyDown(KeyCode.W);
                       
        if(_isJump && _isGrounded)
        {
            Jump();
        }
        else if(!_isGrounded)
        {
            Move();
        }
    }
}
