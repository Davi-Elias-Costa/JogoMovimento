using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimento : MonoBehaviour
{
    float velocidade = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
      
        transform.position += Time.deltaTime * velocidade * Vector3.left;
        velocidade += (float)0.0001 * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position = new Vector2(34.13f, 2.6074f);

        }
    }





}
