using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;
        // Check IF we're receiving input from the D-key. If we are, move the character 1 unit/second to the right.
        if (Input.GetKey(KeyCode.D))
        {
            // Up: positive Y, Right: positive X, Down: negative X, Left: negative X
            // transform.position += new Vector3(1f, 0f, 0f);
            // transform.position += new Vector3(movementSpeed * Time.deltaTime, 0f, 0f);
            input += new Vector3(1f, 0f);
        }
        // If not, check if we're receiving input from the A-key. If we are, move the character 1 unit/second to the left.
        else if (Input.GetKey(KeyCode.A))
        {

            // transform.position -= new Vector3(movementSpeed * Time.deltaTime, 0f, 0f);
            input += new Vector3(-1f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            input += new Vector3(0f, 1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            input += new Vector3(0f, -1f);
        }

        transform.position += input * Time.deltaTime * movementSpeed;
    }
}
