using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnJump = new UnityEvent();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector2 inputVector = Vector2.zero; //W

        if(Input.GetKey(KeyCode.W))
        {
            inputVector +=Vector2.up;
            Debug.Log("User's Input: W");

        }

        
         if(Input.GetKey(KeyCode.A)) //A
        {
            inputVector +=Vector2.left;
            Debug.Log("User's Input: A");

        }

          if(Input.GetKey(KeyCode.S)) //S
        {
            inputVector += Vector2.down;
            Debug.Log("User's Input: S");

        }

          if(Input.GetKey(KeyCode.D)) //D
        {
           inputVector += Vector2.right;
           Debug.Log("User's Input: D");

        }

        OnMove?.Invoke(inputVector);

          if(Input.GetKey(KeyCode.Space)) //Space
        {
            OnJump?.Invoke();
            Debug.Log("User's Input: Jump");

        }

        
        
    }
}


