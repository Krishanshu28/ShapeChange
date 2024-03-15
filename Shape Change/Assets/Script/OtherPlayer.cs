using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OtherPlayer : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rb;
    public Mesh sphere;
    public Mesh cube;
    public bool isSphere = false;
    public bool isCube = true;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Translate(-speed, 0f, 0f);
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Grass")
        {
            if(!isCube)
            {
                speed = 0f;
                transform.Translate(-speed, 0f, 0f);
                StartCoroutine("ChangeCube");
                StopCoroutine("ChangeSphere");
            }
            else
            {
                speed = 0.07f;
                transform.Translate(-speed, 0f, 0f);
            }
            
        }

        else if (collision.gameObject.tag == "Water")
        {
            if(!isSphere)
            {
                speed = 0.05f;
                transform.Translate(-speed, 0f, 0f);
                StartCoroutine("ChangeSphere");
            }
            else
            {
                transform.Translate(-speed, 0f, 0f);
            }
            
        }
    }

    IEnumerator ChangeSphere()
    {
        yield return new WaitForSeconds(2.0f);
        MeshFilter filter = GetComponent<MeshFilter>();
        filter.mesh = sphere;
        speed = 0.1f;
        transform.Translate(-speed, 0f, 0f);
        isSphere = true;
        isCube = false;
    }
    IEnumerator ChangeCube()
    {
        yield return new WaitForSeconds(2.0f);
        MeshFilter filter = GetComponent<MeshFilter>();
        filter.mesh = cube;
        speed = 0.07f;
        transform.Translate(-speed, 0f, 0f);
        isCube = true;
        isSphere = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            print("finish");
            speed = 0f;
            StopAllCoroutines();
            transform.Translate(-speed, 0f, 0f);
        }
    }
}
