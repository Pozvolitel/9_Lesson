using UnityEngine;

public class BombScript : MonoBehaviour
{
    private float _radius = 400;
    private float _force = 1500;

    private void Explosion()
    {
        Collider[] overlappedCollider = Physics.OverlapSphere(transform.position, _radius);
        for (int i = 0; i < overlappedCollider.Length; i++)
        {
            Rigidbody rig = overlappedCollider[i].attachedRigidbody;
            if(rig)
            {
                rig.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Car"))
        {
            Explosion();
            Destroy(gameObject);
        }
    }
}
