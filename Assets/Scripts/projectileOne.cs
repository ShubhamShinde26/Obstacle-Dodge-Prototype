using UnityEngine;

public class projectileOne : MonoBehaviour
{

    Vector3 targetPosition;
    [SerializeField] Transform target;
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        


    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Target")
        {
            Destroy(gameObject);
        }
            
            }
    }

