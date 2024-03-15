using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rb;
    public GameObject panel;
 

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(-speed, 0f, 0f);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Grass")
        {
            if (!gameManager.isSphere)
            {
                speed = 0.07f;
                transform.Translate(-speed, 0f, 0f);
            }
            else
            {
                speed = 0f;
                transform.Translate(-speed, 0f, 0f);
            }
        }

        if (collision.gameObject.tag == "Water")
        {
            
            if (gameManager.isSphere)
            {
                speed = 0.1f;
                transform.Translate(-speed, 0f, 0f);
            }
            else
            {
                speed = 0.05f;
                transform.Translate(-speed, 0f, 0f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            //gameOver
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
