using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnTransform;
    public Quaternion bulletDirection;
    public float shootDelay;
    private bool canShoot = true;

    public void Shoot()
    {
        if (canShoot)
        {
                        // game object   location          rotation
            Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletDirection);
            StartCoroutine(ShootDelayCoroutine());
        }
    }

    private IEnumerator ShootDelayCoroutine()
    {
        canShoot = false;
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }
}
