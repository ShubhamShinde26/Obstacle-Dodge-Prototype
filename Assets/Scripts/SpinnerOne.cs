using UnityEngine;

public class SpinnerOne : MonoBehaviour
{

   [SerializeField] float rotateX;
   [SerializeField] float rotateY;
   [SerializeField] float rotateZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ);
    }
}
