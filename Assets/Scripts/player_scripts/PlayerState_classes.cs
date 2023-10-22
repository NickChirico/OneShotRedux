using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_classes {

}

/* #################
 * ## READY STATE ##
 * #################
 */
public class Ready_PS : PlayerState {

    public Ready_PS( PlayerStateManager sm, string name, float duration ) : base( sm, name, duration ) { }
    public override void UpdateState() {
        // READY : read all inputs
        bool firePressed = InputAction.Player.Fire.ReadValue<float>() > 0;
        bool altPressed = InputAction.Player.Fire2.ReadValue<float>() > 0;

        // Consider state priority - if multiple buttons are pressed, which action should take priority?
        // 'PrimaryFire' is highest priority right now
        if ( firePressed ) {
            SM.ChangeStateTo( SM.getFirePrimeState() );
        } else if ( altPressed ) {
            SM.ChangeStateTo( SM.getFireAltState() );
        }
    }
}
/* ##################
 * ## PRIMARY FIRE ##
 * ##################
 */
public class PrimaryFire_PS : PlayerState {
    public PrimaryFire_PS( PlayerStateManager sm, string name, float duration ) : base( sm, name, duration ) { }

    public override void UpdateState() {
        if (timer < stateDuration ) { // windUpDuration
            timer += Time.deltaTime;
        } else {
            // state logic
        }
    }

    public override void Enter() {
        base.Enter();
        // ShotControl.shoot ...
        // or, WeaponControl.FirePrimary();
        //Duration = something
        // SpecificVar = something;

    }
}

/* ####################
 * ## ALTERNATE FIRE ##
 * ####################
 */
public class AlternateFire_PS : PlayerState {
    public AlternateFire_PS( PlayerStateManager sm, string name, float duration ) : base( sm, name, duration ) { }

    public override void UpdateState() {
        if ( timer < stateDuration ) { // windUpDuration
            timer += Time.deltaTime;
        } else {
            // state logic
        }
    }
}

