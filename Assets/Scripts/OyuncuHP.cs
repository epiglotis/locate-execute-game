using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHP : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
