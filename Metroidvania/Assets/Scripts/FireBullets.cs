using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireBullets : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    public void Shoot(InputAction.CallbackContext context)
    {
        var bullet = Instantiate(projectile, transform.position, Quaternion.identity);
        
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
