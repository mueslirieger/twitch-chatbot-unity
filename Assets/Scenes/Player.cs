using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _characterController;
    
    // Start is called before the first frame update
    void Start()
    {
        _characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HandleInteractionCommand(string data)
    {
        Debug.Log("Hi");
        
        switch (data)
        {
            case "up":
                _characterController.Move(Vector3.up);
                break;
            case "down":
                _characterController.Move(Vector3.down);
                break;
            case "forward":
                _characterController.Move(Vector3.forward);
                break;
            case "backward":
                _characterController.Move(Vector3.back);
                break;
            case "left":
                _characterController.Move(Vector3.left);
                break;
            case "right":
                _characterController.Move(Vector3.right);
                break;
            default:
                Debug.Log("Unknown option: " + data);
                break;
        }
    }
}
