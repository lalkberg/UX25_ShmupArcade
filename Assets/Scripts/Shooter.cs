using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnTransform;

    public void Shoot()
    {
                    // game object   location          rotation
        Instantiate(bulletPrefab, bulletSpawnTransform.position, Quaternion.identity);
    }
}
