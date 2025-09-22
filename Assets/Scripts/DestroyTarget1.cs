using UnityEngine;

public class DestroyTarget1 : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Projectile1")
        {
            Destroy(gameObject);
        }
            
            }
}
