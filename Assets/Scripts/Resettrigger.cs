using UnityEngine;

public class Resettrigger : MonoBehaviour
{
   [SerializeField] GameObject resetPos;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

            other.gameObject.transform.position = resetPos.transform.position;
    }
}
