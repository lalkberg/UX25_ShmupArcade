using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // Check IF we're receiving input from the D-key. If we are, move the character 1 unit to the right.
        if (Input.GetKey(KeyCode.D))
        {
            // Up: positive Y, Right: positive X, Down: negative X, Left: negative X
            transform.position += new Vector3(1f, 0f, 0f);
        }
    }
}
