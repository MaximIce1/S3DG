using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //сбор назначений кнопок и направления движения
    [SerializeField] KeyCode keyOne; 
    [SerializeField] KeyCode keyTwo;
    [SerializeField] KeyCode keyThree;
    [SerializeField] KeyCode keyFour;
    [SerializeField] Vector3 moveDirection;

    
    private void FixedUpdate() //система управления
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }

        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyThree))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyFour))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }


        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
        }
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
