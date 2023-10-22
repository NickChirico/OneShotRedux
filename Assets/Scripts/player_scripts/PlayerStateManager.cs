using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    private PlayerState_classes playerStates;

    private PlayerState currentState;
    private PlayerState Ready;
    private PlayerState FirePrime;
    private PlayerState FireAlt;
    private PlayerState Switch;
    private PlayerState Disabled;

    // temp
    private bool managerIsActive = true;


    private void Start() {

        // Define States
        Ready = new Ready_PS(this, "Ready", -1);
        FirePrime = new PrimaryFire_PS( this, "FirePrime", 0 ); // ShotControl.getShotDuration();
        // FireAlt = 
    
        
    }


    private void Update() {
        if (this.managerIsActive && currentState != null) {
            currentState.UpdateState();
        }
    }

    public void ChangeStateTo(PlayerState newState ) {
        if(currentState != null) {
            currentState.Exit();
        }
        currentState = newState;
        currentState.Enter();
    }

    public void ToReadyState() {
        if (!currentState.isState( Ready ))
            ChangeStateTo( Ready );
    }

    public PlayerState getReadyState() { return Ready; }
    public PlayerState getFirePrimeState() { return FirePrime; }
    public PlayerState getFireAltState() { return FireAlt; }
    public PlayerState getSwitchState() { return Switch; }
    public PlayerState getDisabledState() { return Disabled; }

}
