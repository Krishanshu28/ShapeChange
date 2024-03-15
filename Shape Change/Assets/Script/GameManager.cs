using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cubePlayer;
    public GameObject spherePlayer;

    public bool isSphere = false;
    public bool isCube = true;
    // Start is called before the first frame update
    void Start()
    {
        

        // Initially enable the cube and disable the circle
        
        //circle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCircle()
    {
        cubePlayer.SetActive(false);
        isCube = false;
        isSphere = true;
        spherePlayer.SetActive(true);
    }
    public void OnCube()
    {
        spherePlayer.SetActive(false);
        isCube = true;
        isSphere = false;
        cubePlayer.SetActive(true);
    }
}
