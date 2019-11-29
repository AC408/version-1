using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float verticalForce = 0.0f;
    public float horizontalForce = 0.0f;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalForce, verticalForce);

        //time per frame rate
        float x = Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalForce += 0.2f;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalForce -= 0.2f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalForce -= 0.2f;
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalForce += 0.2f;
        }
    }
}
