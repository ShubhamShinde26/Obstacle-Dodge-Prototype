using UnityEngine;

public class Droppers : MonoBehaviour
{
   [SerializeField] GameObject dropper;
     void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Player")
        {
            dropper.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
