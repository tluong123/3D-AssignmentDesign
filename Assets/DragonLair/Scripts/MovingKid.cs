using UnityEngine;

public class MovingKid : MonoBehaviour
{
    float translationSpeed = 15.0f;
    float rotationSpeed = 100.0f;
    Animator anim;

    public float jumpForce = 5f;
    public Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * translationSpeed;
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("charSpeed", translation < 0 ? -1.0f : 1.0f);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        // Jump on Spacebar
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            anim.SetTrigger("Jump"); // Trigger the jump animation
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Make the player physically jump
            isGrounded = false;
        }
    }

void OnCollisionStay(Collision collision)
{
    Debug.Log("Collided with: " + collision.gameObject.name);

    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
        Debug.Log("Landed on ground");
    }
}
}
