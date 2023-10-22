using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState_legacy
{
    protected PlayerStateManager_legacy SM;
    protected Player_legacy player;
    protected MovementController_legacy Move;
    protected ShotController_legacy Shot;
    protected AltShotController Alt;
    protected SpecialController Spec;
    protected MeleeController Melee;

    protected PlayerInputActions InputAction;

    protected string Name;
    protected float Duration;
    protected float PrepDuration;
    protected int AttackInterval;

    protected float timer;

    public PlayerState_legacy(PlayerStateManager_legacy manager, string name)
    {
        InputAction = MovementController_legacy.GetInputActions;
        Move = MovementController_legacy.GetMoveController;
        Shot = ShotController_legacy.GetShotControl;
        Alt = AltShotController.GetAltControl;
        Melee = MeleeController.GetMeleeControl;
        Spec = SpecialController.GetSpecialController;
        SM = manager;
        Name = name;
    }

    public PlayerState_legacy(PlayerStateManager_legacy manager, string name, float dur)
    {
        InputAction = MovementController_legacy.GetInputActions;
        Move = MovementController_legacy.GetMoveController;
        Shot = ShotController_legacy.GetShotControl;
        Alt = AltShotController.GetAltControl;
        Melee = MeleeController.GetMeleeControl;
        Spec = SpecialController.GetSpecialController;
        SM = manager;
        Name = name;
        Duration = dur;
    }
    public PlayerState_legacy(PlayerStateManager_legacy manager, Player_legacy p, string name, float dur)
    {
        InputAction = MovementController_legacy.GetInputActions;
        Move = MovementController_legacy.GetMoveController;
        Shot = ShotController_legacy.GetShotControl;
        Alt = AltShotController.GetAltControl;
        Melee = MeleeController.GetMeleeControl;
        Spec = SpecialController.GetSpecialController;
        SM = manager;
        player = p;
        Name = name;
        Duration = dur;
    }

    public PlayerState_legacy(PlayerStateManager_legacy manager, string name, float dur, float prepDur, int interval)
    {
        InputAction = MovementController_legacy.GetInputActions;
        Move = MovementController_legacy.GetMoveController;
        Shot = ShotController_legacy.GetShotControl;
        Alt = AltShotController.GetAltControl;
        Melee = MeleeController.GetMeleeControl;
        Spec = SpecialController.GetSpecialController;
        SM = manager;
        Name = name;
        Duration = dur;
        PrepDuration = prepDur;
        AttackInterval = interval;
    }

    // Update
    public abstract void DoState();

    // Enter/Exit
    public virtual void Enter()
    {
        timer = 0;
    }
    public virtual void Exit()
    {

    }

    // Getters/ Setters
    public string GetName()
    {
        return Name;
    }
    public float GetDuration()
    {
        return Duration;
    }




}
