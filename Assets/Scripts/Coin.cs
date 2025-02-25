using UnityEngine;

public class Coin : MonoBehaviour
{
      public float speed; // Base speed of rotation
      public int coin = 1; 

     public Gamemanager gameManager; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //transform.Rotate(Vector3.right, 2 * speed * Time.deltaTime);
         transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        gameManager.IncrementScore();

        //Destroy on collision
        Destroy(gameObject);

       
    }

 
}
