using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
    public AudioSource[] sounds;
    private AudioSource flap; 
    private AudioSource DeathSound; 
    public GameObject deathFX;
   
    public float position;
    public float speed;
    public Rigidbody rb;
    public static int score;
    public TextMeshProUGUI score_update;

    void Start()
    {
        score = 0;
        speed = 10.0f;
        rb = GetComponent<Rigidbody>();
        sounds = GetComponents<AudioSource>();
        flap = sounds[0]; 
        DeathSound = sounds[1];        
    }
    
    void Update()
    {
        Movement();
    }
    

    void Movement() {
        position = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)) 
        {
            rb.velocity = Vector2.up * speed;
            flap.Play();
        }         
    }
   
    void Death()
    {
         reset();
         SceneManager.LoadScene("DeathScene");
    }


    void OnCollisionEnter(Collision other)
    {
          
        if (other.gameObject.tag == "PIPE" || other.gameObject.tag == "BUILDING") {
            DeathSound.Play(); 
            Instantiate(deathFX, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            Death();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "POINT") {
            score++;
            score_update.text = score.ToString();
        }

    }

    void reset() {
        score = 0;
        score_update.text = "0";
    }
}
