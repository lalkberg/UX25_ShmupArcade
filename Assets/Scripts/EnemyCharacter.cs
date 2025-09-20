using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    public float movementSpeed;
    public bool isShooter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the enemy DOWN every frame regardless of input
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;

        if (isShooter)
        {
            GetComponent<Shooter>().Shoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Health health))
        {
            health.Damage(1);
        }
        Destroy(gameObject);
    }
}
