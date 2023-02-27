using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    
    public float horizontalInput;
    public float forwardInput;

    public float movementSpeed = 10f;

    public GameObject winText;
    public GameObject loseText;

    void Start() 
    {   
        
        winText.SetActive(false);
        loseText.SetActive(false);        
    }

    void Update()
    {
        if(PauseMenu.isPaused == false)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            Vector3 move = transform.right * horizontalInput + transform.forward * forwardInput;

            characterController.Move(move * Time.deltaTime * movementSpeed);
        }
    }

    private void OnTriggerEnter(Collider other) {
        
        
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            loseText.SetActive(true);
            SetWinText();
        }
        
        if (other.CompareTag("Escape"))
        {
            Debug.Log("You Win!");
            winText.SetActive(true);
            SetLoseText();
        }   
    }

    void SetWinText()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        
    void SetLoseText()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
