using System.Runtime.CompilerServices;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rouge : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    public float jumpForce = 250;

    public bool Grounded = true;

    public int coinsCollector = 0;

    public TMP_Text coinsText;

    public int currenthealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Grounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed);

        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Grounded = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        coinsCollector++;
        coinsText.text = coinsCollector.ToString();
    }
   else if (other.GetComponent<Wizard>())
      { 
        currentHealth;
        healthText.text = currentHealth.ToString();
       if (currentHealth <= 0
        
     
        {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Scene.LoadScene("SampleScene")
        }

   else if (other.GetComponent<goal>()
    {
    SceneManager.LoadScene(other.GetComponemt<goal>().NextLevel);
}
}
}


