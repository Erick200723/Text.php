using UnityEgine;

public class Tiro : MonoBehaviour
{
   public GameObject bulletPrefab;
   public Transform firePont;
   public float bulletSpeed = 20f;
   
   void Start() 
    { if(input.GetButtonDow("Fire1"))
      {
        Shoot();
      }
    }

    void Shoot()
    {
        GameObjet bullet = instantiate(bulletPrefab, firePont.position,firePoint.rotation);
        Rigidbody rb =
        bullet.GetComponet<Rigidbody>();
        rb.velocity = firePont.forward*
        bulletSpeed;
    }
}
