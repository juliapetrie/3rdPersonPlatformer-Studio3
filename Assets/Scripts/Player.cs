using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float jumpHeight;

    private bool plane;

    public void MovePlayer(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        playerRigidbody.AddForce(inputXZPlane * playerSpeed);
    }

      public void Jump() 
            
    {
        if(plane)
        {
        playerRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                

        plane = false;

        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.name == "Plane")
        {
            plane = true;
        }
    }
}

