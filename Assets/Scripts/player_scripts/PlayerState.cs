using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState {
    protected PlayerStateManager SM;

    protected string stateName;
    protected float stateDuration;
    protected PlayerInputActions InputAction;


    protected float timer;


    public PlayerState( PlayerStateManager sm, string name, float duration ) {
        InputAction = MovementController_legacy.GetInputActions;
        SM = sm;
        stateName = name;
        stateDuration = duration;
    }

    public abstract void UpdateState();

    public virtual void Enter() {
        timer = 0;
    }

    public virtual void Exit() {

    }

    public bool isState(PlayerState state ) {
        if (this.Equals( state ))
            return true;
        else
            return false;
    }
    public string GetName() {
        return stateName;
    }
    public float GetDuration() {
        return stateDuration;
    }
}
