using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeed : MonoBehaviour
{

    PlayerMovement playerMovement;

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other is CapsuleCollider)
        {
            playerMovement.AddSpeed();
            Destroy(this.gameObject);
        }
    }

}
