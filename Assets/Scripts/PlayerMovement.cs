using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputManager inputManager = new InputManager();
    private void Update()
    {
        inputManager.Jump();     
    }
}
