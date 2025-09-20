using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnTransform;
    public Quaternion bulletDirection;

    public void Shoot()
    {
                    // game object   location          rotation
        Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletDirection);
    }
}
