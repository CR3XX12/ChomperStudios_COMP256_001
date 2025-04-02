using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerOnTouch : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("[Crawler] Hit the player!");
            PlayerHealth player = FindObjectOfType<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage();
            }
        }
    }
}
