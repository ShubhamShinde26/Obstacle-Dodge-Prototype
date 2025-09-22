using UnityEngine;

public class projectileOneTrigger : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
            Destroy(gameObject);
        }
    }
}
