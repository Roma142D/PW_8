using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] protected float _jumpPower;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected Rigidbody2D _playerRigidbody;
    protected bool _isGrounded;
    protected bool _isJump;
    [SerializeField] private float _groundCheckDistance;
    
    public void Jump()
    {
        _playerRigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {
        _isGrounded = Physics2D.Raycast(_playerRigidbody.position, Vector2.down, _groundCheckDistance);
        Debug.DrawLine(_playerRigidbody.position, _playerRigidbody.position + Vector2.down * _groundCheckDistance, Color.red);
    }
    private void Update()
    {
        _isJump = Input.GetKeyDown(KeyCode.W);

        if(_isJump)
        {
            Jump();
        }
    }
}
