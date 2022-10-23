using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    [SerializeField] private FixedJoint _fixed;
    [SerializeField] private Rigidbody _newRig;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Trail"))
        {
            _fixed.connectedBody = _newRig;
        }
    }
}
