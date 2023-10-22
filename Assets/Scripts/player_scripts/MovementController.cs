using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Executes Player Movement Functions 
 * - Functions should only be called from 'Player' 
 */
public class MovementController : MonoBehaviour {
    public enum MoveType { Normal, Boost, Hold }
    private MoveType moveType;

    [Header("Movement Stats")]
    public float baseMoveSpeed;
    public float maxMoveSpeed;

    // Timescales: The rate movespeed returns to base, in this state
    public float normalTimeScale;
    //public float boostTimeScale;

    /** PRIVATE VARS **/
    private Rigidbody2D rb;

    private PlayerInputActions playerInputActions;
    private Vector2 direction;
    private float currentMoveSpeed;
    public float targetMoveSpeed;

    private void Start() {
        playerInputActions = Player.GetInputActions;
        rb = this.GetComponent<Rigidbody2D>();
        currentMoveSpeed = baseMoveSpeed;
        moveType = MoveType.Normal;
    }
    private void FixedUpdate() {
        direction = playerInputActions.Player.Move.ReadValue<Vector2>();
        rb.velocity = direction *= currentMoveSpeed;
    }

    private void Update() {
        float timescale = Time.deltaTime;
        float movespeed = 0;
        switch (moveType) {
            case MoveType.Normal:
                // Normal Movement
                movespeed = baseMoveSpeed;
                timescale = Time.deltaTime * normalTimeScale;
                break;
            case MoveType.Boost:
                // Boosting
                break;
            case MoveType.Hold:
                // Holding
                break;
            default:
                break;
        }
        /*
         * targetMoveSpeed::    The speed you are accelerating/decelerating towards
         * movespeed::          Current moving speed
         * timescale::          The rate which you move from current to target speed;
         */
        targetMoveSpeed = Mathf.Lerp( targetMoveSpeed, movespeed, timescale );
        currentMoveSpeed = targetMoveSpeed;
    }

    public Vector2 GetMovementDirection() { return direction; }
    public MoveType GetMoveType() { return moveType; }
}
