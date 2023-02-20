using System.Collections;
using System.Collections.Generic;
using UnityEngine;

AssetPush

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    
    public float horizontalInput;
    public float forwardInput;

    public float movementSpeed = 10f;

 main
    public GameObject winText;
    public GameObject loseText;

    private void Start() {
        
        winText.SetActive(false);
        loseText.SetActive(false);        
    }


    // Update is called once per frame
 AssetPush
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontalInput + transform.forward * forwardInput;

        characterController.Move(move * Time.deltaTime * movementSpeed);
 main
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            loseText.SetActive(true);
        }
        
        if (other.CompareTag("Escape"))
        {
            Debug.Log("You Win!");
            winText.SetActive(true);
        }   




 AssetPush
    }
}
