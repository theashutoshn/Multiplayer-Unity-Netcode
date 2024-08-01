using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerNetwork : NetworkBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;

        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) 
            moveDir.z = +1f;
        if (Input.GetKey(KeyCode.S))
            moveDir.z = -1f;
        if (Input.GetKey(KeyCode.D))
            moveDir.x = +1f;
        if (Input.GetKey(KeyCode.A))
            moveDir.x = -1f;

        transform.position += moveDir * 5f * Time.deltaTime;
    }
}
