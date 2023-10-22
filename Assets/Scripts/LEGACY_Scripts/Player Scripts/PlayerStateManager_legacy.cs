using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager_legacy : MonoBehaviour
{
    [SerializeField] private PlayerState_legacy currentState;
    protected static PlayerStateManager_legacy this_SM;
    protected static MovementController_legacy MoveControl;
    protected static ShotController_legacy ShotControl;
    protected static AltShotController AltControl;
    //protected static EquipmentManager EquipControl;
    protected static MeleeController MeleeControl;
    protected static WeaponManager WeaponControl;
    protected static Player_legacy this_Player;

    public PlayerState_legacy Ready;
    public PlayerState_legacy Shooting;
    public PlayerState_legacy Dashing;
    public PlayerState_legacy AltFiring;
    public PlayerState_legacy Reloading;
    public PlayerState_legacy Rechamber;
    public PlayerState_legacy Special;
    public PlayerState_legacy Damaged;

    public PlayerState_legacy MeleeAttack;
    public PlayerState_legacy Attack1;
    public PlayerState_legacy Attack2;
    public PlayerState_legacy Attack3;
    public PlayerState_legacy AttackRecover;

    bool isActive;

    void Start()
    {
        this_SM = this;
        this_Player = this.GetComponent<Player_legacy>();
        MoveControl = this.GetComponent<MovementController_legacy>();
        ShotControl = this.GetComponent<ShotController_legacy>();
        AltControl = this.GetComponent<AltShotController>();
        //EquipControl = FindObjectOfType<EquipmentManager>();
        WeaponControl = FindObjectOfType<WeaponManager>();
        MeleeControl = this.GetComponent<MeleeController>();

        // Define States
        Ready = new PlayerState_Ready(this_SM, "Ready");
        Shooting = new PlayerState_Shooting(this_SM, "Shooting", ShotControl.shotDuration);
        Dashing = new PlayerState_Dash(this_SM, "Dash", MoveControl.dashDuration);
        Damaged = new PlayerState_Damaged(this_SM, this_Player, "Damaged", this_Player.invulnDuration);
        AltFiring = new PlayerState_AltFire(this_SM, "AltFire");
        Special = new PlayerState_Special(this_SM, "Special");
        Reloading = new PlayerState_Reloading(this_SM, "Reloading", ShotControl.reloadDuration);
        Rechamber = new PlayerState_Rechamber(this_SM, "Rechamber", ShotControl.rechamberDuration);

        MeleeAttack = new PlayerState_MeleeAttack(this_SM, "MeleeAtk");
        //Attack1 = new PlayerState_MeleeAttack(this_SM, "Attack1", MeleeControl.attackDuration_1, MeleeControl.preAttackDelay_1, 1);
        //Attack2 = new PlayerState_MeleeAttack(this_SM, "Attack2", MeleeControl.attackDuration_2, MeleeControl.preAttackDelay_2, 2);
        //Attack3 = new PlayerState_MeleeAttack(this_SM, "Attack3", MeleeControl.attackDuration_3, MeleeControl.preAttackDelay_3, 3);
        AttackRecover = new PlayerState_MeleeRecover(this_SM, "AtkRecover", MeleeControl.recoverTime, 0, 1);

        ChangeState(Ready);
    }

    public bool IsMelee()
    {
        return WeaponControl.IsMelee();
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
            currentState.DoState();
    }

    public void ChangeState(PlayerState_legacy newState)
    {
        if (currentState != null)
            currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public PlayerState_legacy GetCurrentState()
    {
        return currentState;
    }
    public string GetStateName()
    {
        return currentState.GetName();
    }
    public void BackToReady()
    {
        ChangeState(Ready);
    }
    public void ActivePlayer(bool b)
    {
        isActive = b;
    }

    /*public void PlayAnimation(AnimationState animationState)
    {
        if (currentAnimationState != animationState)
        {
            myBossAnimator.Play(animationState.ToString());
            currentAnimationState = animationState;
        }
    }*/
}
