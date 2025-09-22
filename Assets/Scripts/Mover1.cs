using UnityEngine;

public class Mover1 : MonoBehaviour
{
   [SerializeField] float moveSpeed;
   [SerializeField] float moveDistance;

    Vector3 startPos;

    int direction = -1;
    // Start i
    //s called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * direction, 0, 0);

        if (Vector3.Distance(startPos, transform.position) >= moveDistance)
        {
            direction *= -1;
                
        }
        
            }
}
