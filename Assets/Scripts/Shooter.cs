using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void Shoot()
    {
                    // game object   location          rotation
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
