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
    public bool dead = false;
    public TextMeshProUGUI score_update;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        speed = 15.0f;
        rb = GetComponent<Rigidbody>();
        sounds = GetComponents<AudioSource>();
        flap = sounds[0]; 
        DeathSound = sounds[1];        
    }


    // Update is called once per frame
    
    void Update()
    {
        Movement();
    }
    

    void Movement() {
        position = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = Vector2.up * speed;
            flap.Play();
        }         
    }
   
    void Death()
    {
         dead = true;
         reset();
         SceneManager.LoadScene("DeathScene");
    }


    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
          
        if (other.gameObject.tag == "PIPE" || other.gameObject.tag == "BUILDING") {
            DeathSound.Play(); 
            Instantiate(deathFX, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            Death();
           
        }

    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "POINT") {
            score++;
            score_update.text = score.ToString();
        }
        // If the y axis of the pipes is < 0:
        //     score++;
        //     score_update.text = score.ToString();
    }

    void reset() {
        dead = false;
        score = 0;
        score_update.text = "0";
    }
}
