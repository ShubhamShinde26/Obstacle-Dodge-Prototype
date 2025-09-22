using UnityEngine;

public class playerMove : MonoBehaviour
{

    
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0f, turn, 0f);

        float move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0f, 0f, move);
      
    }
}
