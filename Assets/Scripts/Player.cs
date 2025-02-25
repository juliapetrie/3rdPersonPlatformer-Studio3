using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float jumpHeight;
     [SerializeField] private InputManager inputManager;

    private bool onPlane = true;

    public void MovePlayer(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        playerRigidbody.AddForce(inputXZPlane * playerSpeed);
    }

      public void Jump() 
            
    {
        if(onPlane)
        {
        playerRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        onPlane = false;

        }
    }

    private void OnCollisionEnter(Collision c)
    {
         if (c.gameObject.CompareTag("Plane"))
        {
            onPlane = true;
        }
    }

     private void OnCollisionExit(Collision c)
    {
         if (c.gameObject.CompareTag("Plane"))
        {
            onPlane = false;
        }
    }
}