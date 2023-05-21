using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Trigger : MonoBehaviour
{
    [SerializeField] float triggerMoveSpeed = 10f;
    Player_Movement player_Movement;
    void Awake()
    {
        player_Movement = FindObjectOfType<Player_Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    private void ProcessMovement()
    {
        if (player_Movement.isMoving)
        {
            float yDirection = triggerMoveSpeed * Time.deltaTime;
            transform.Translate(0, yDirection, 0);
        }
    }
}
