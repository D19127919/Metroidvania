using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Powerups : MonoBehaviour
{
    [SerializeField] private Collider2D playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive = 100;
    [SerializeField] private bool DoubleJump = false;
    [SerializeField] private bool Shoot = false;
    [SerializeField] private Player_Movement playermove;
    [SerializeField] private FireBullets shooter;
    [SerializeField] private GameObject powerText;

    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            manager.AddScore(scoreToGive);

            if (DoubleJump)
            {
                playermove.MaxJump += 1;
            }

            if (Shoot)
            {
                shooter.canShoot = true;
            }
            powerText.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.RespawnPlayer();
        }
    }

}
