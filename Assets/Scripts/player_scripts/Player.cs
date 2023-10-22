using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 'Player' is the MonoBehavior that gets passed to enemies and other object
 * 'Player' has a reference to weapon controller, movement controller, and all other accessible controllers
 * Player is the API layer for other classes to access and manipulate the player. 
 * 
 */
public class Player : MonoBehaviour {

    private static PlayerInputActions playerInputActions;
    public static PlayerInputActions GetInputActions { get { return playerInputActions; } }

    private MovementController moveControl;

    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        moveControl = this.GetComponent<MovementController>();

    }
}
