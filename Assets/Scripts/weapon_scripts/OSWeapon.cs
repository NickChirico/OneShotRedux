using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    * Abstract Weapon Class 
    * 
    * 
    */
public abstract class OSWeapon
{
    [Header("OSWeapon")]
    public string weaponName;

    public int primaryBaseDamage;
    public float primaryBaseRange;

    public int alternateBaseDamage;
    public float alternateBaseRange;

    /**
        * Fire the weapon's primary shot
        */
    public abstract void PrimaryFire();

    /**
        * Fire the weapon's alternate shot
        */
    public abstract void AlternateFire();
}
