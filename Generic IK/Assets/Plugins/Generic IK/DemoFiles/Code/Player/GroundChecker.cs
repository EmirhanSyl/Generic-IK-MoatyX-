using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded = false;

    private void OnTriggerStay(Collider other)
    {
        isGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }
}
