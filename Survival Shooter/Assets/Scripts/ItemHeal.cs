using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeal : MonoBehaviour
{

    PlayerHealth playerHealth;

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other is CapsuleCollider)
        {
            playerHealth.AddHealth();
            Destroy(this.gameObject);
        }
    }

}
