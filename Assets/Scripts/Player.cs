using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHori = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHori * 0.1f, moveVert * 0.1f, 0);
            transform.position = transform.position + movement;
        }
    }
     void Update()
    {
        HandleMovement();
    }
}
