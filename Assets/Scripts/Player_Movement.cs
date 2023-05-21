using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    public bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            float xDirection = moveSpeed * Time.deltaTime;
            transform.Translate(xDirection, 0, 0);
        }
    }

    public bool GetIsMoving()
    {
        return isMoving;
    }
}
