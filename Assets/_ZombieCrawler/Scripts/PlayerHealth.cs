using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1;

    public void TakeDamage()
    {
        health--;

        if (health <= 0)
        {
            Debug.Log("[PlayerHealth] Player died.");
            // Save score before switching scenes
            PlayerPrefs.SetInt("FinalScore", ScoreManager.Instance.score);
            SceneManager.LoadScene("DeathScene"); // make sure this matches your scene name
        }
    }
}
