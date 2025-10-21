using UnityEngine;

public class BounceOffWall : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _bounceForce = 6.0f;

    // ------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Wall"))
        {
            Vector3 meToCenter = (-transform.position).normalized;
            _rigidBody.AddForce(meToCenter * _bounceForce, ForceMode.Impulse);
        }
    }
}