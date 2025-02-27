using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed, jumpHeight;
    [SerializeField] private GameObject directionIndicator;
    private bool onGround = true;

    public void MovePlayer(Vector2 input)
    {
        if (directionIndicator == null) return;

        Vector3 cameraForward = directionIndicator.transform.forward;
        Vector3 cameraRight = Vector3.Cross(Vector3.up, cameraForward);
        cameraForward.y = cameraRight.y = 0;

        Vector3 moveDirection = (cameraForward * input.y + cameraRight * input.x).normalized;
        rb.linearVelocity = new Vector3(moveDirection.x * speed, rb.linearVelocity.y, moveDirection.z * speed);

        // Rotate player to cam direction
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(cameraForward), Time.deltaTime * 10f);
    }

    public void Jump()
    {
        if (onGround)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane")) onGround = true;
    }
}
