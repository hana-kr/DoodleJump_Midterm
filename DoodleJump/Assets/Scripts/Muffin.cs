using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muffin : MonoBehaviour
{

    bool buttom = false;
    float move = 0f;
    int speed = 5;
    GameObject Deathzone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         move = Input.GetAxis("Horizontal")*speed;
        Vector2 vec = GetComponent<Rigidbody2D>().velocity;
        vec.x = move;
        GetComponent<Rigidbody2D>().velocity = vec;

        if(Deathzone != null)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("SampleScene");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(buttom);
        if (collision.gameObject.CompareTag("Platform")) {

            if (collision.relativeVelocity.y>=0f)
            {
                Vector2 v = GetComponent<Rigidbody2D>().velocity;
                v.y = 10f;

                GetComponent<Rigidbody2D>().velocity = v;

            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            buttom = true;
        }
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Deathzone = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            buttom = false;
        }

    }
}
