using UnityEngine;

public class DestroyTargetTwo : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Projectile2")
        {
            Destroy(gameObject);
        }
            
            }
}
