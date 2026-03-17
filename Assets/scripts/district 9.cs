using UnityEngine;

public class maniac : MonoBehaviour
{
  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);  
    }
}
