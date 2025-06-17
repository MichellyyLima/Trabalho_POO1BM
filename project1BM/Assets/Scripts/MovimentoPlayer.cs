using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;
    
    void Start()
    {
        Debug.Log("START"); 
        TryGetComponent(out rb);
    }

    
    void Update()
    {
        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        
        UnityEngine.Vector3 movimento = new Vector3(h, 0, v);
        rb.AddForce(movimento * velocidade * Time.deltaTime, ForceMode.Impulse);
     

        
    }
}