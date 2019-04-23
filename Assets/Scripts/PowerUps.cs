using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public float multiplier = 1.4f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider2D player)
    {
        PlayerController stats = player.GetComponent<PlayerController>();
        stats.speed *= multiplier;
        Destroy(gameObject);
    }
}
