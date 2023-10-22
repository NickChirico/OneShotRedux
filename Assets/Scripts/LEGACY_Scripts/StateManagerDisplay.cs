using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StateManagerDisplay : MonoBehaviour
{
    TextMeshPro display;
    public bool isEnemy;
    EnemyStateManager enemyManager;
    PlayerStateManager_legacy playerManager;

    void Start()
    {
        display = this.GetComponent<TextMeshPro>();
        if(isEnemy)
            enemyManager = GetComponentInParent<EnemyStateManager>();
        else
            playerManager = GetComponentInParent<PlayerStateManager_legacy>();
    }

    void Update()
    {
        if (isEnemy)
            display.text = enemyManager.GetStateName();
        else
            display.text = playerManager.GetStateName();
    }
}
