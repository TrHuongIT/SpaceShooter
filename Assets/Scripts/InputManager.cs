using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerActions playerActions;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerActions = playerInput.Player;
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void LateUpdate()
    {
        playerMovement.ShipMove(playerActions.MoveAD.ReadValue<Vector2>());
        playerMovement.ShipMoveTouchscreen(playerActions.MoveTouchscreen.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }
}
