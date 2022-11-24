using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // click on plane, go to the inspector tab, and under transform change the x and z scale from 1 to 5
    Rigidbody rb;
    float xInput;
    float zInput;
    public float moveSpeed;
    // make moveSpeed public in order to access it in the inspector tab

    public AudioClip coinSound;

    private void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate(){
        float xVelocity = xInput * moveSpeed;
        float zVelocity = zInput * moveSpeed;
        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);
        // rb.velocity.y means whatever the previous velocity was for the rigidbody, the y velocity will be the same
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Coin"){
            Destroy(collision.gameObject);
            // disable capsule collider for the child coin
            // add sphere collider for the parent coin

            // GetComponent<AudioSource>().Play();
            // whenever the user has collected a coin, the coin effect sound downloaded from a random website will be played
            // make sure you uncheck the play on awake checkbox in the inspector tab for the cube since you only want the sound to be played when the user has collected the coin, not when the game has started

            GetComponent<AudioSource>().PlayOneShot(coinSound);
            // this does the same thing the GetComponent<AudioSource>().Play() does, however it is more flexible to do it this way because if you want to add a different sound for a different object,
            // you can simply drag the audio file you want into the audioclip variable located in the inspector tab under the player script
        }
    }
}
