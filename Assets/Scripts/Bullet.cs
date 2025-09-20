using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(0, movementSpeed, 0) * Time.deltaTime;
        transform.position += transform.up * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Health health))
        {
            Debug.Log("Bullet collision!");
            health.Damage(1);
        }
        Destroy(gameObject);
    }
}
