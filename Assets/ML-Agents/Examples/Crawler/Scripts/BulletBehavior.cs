using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Auto-destroy bullet after X seconds
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("[Bullet] Hit: " + other.gameObject.name);

        // Start from what we hit
        Transform crawler = other.transform;

        // Go up the hierarchy until we find an object tagged "Enemy"
        while (crawler != null && !crawler.CompareTag("Enemy"))
        {
            crawler = crawler.parent;
        }

        // If we found the enemy object, destroy it
        if (crawler != null)
        {
            Debug.Log("[Bullet] Enemy hit! Destroying: " + crawler.name);
            Destroy(crawler.gameObject);

            // Add score
            ScoreManager.Instance.AddScore(1);
        }
        else
        {
            Debug.Log("[Bullet] Hit something, but it wasn’t tagged 'Enemy'");
        }

        // Destroy the bullet itself after collision
        Destroy(gameObject);
    }
}
