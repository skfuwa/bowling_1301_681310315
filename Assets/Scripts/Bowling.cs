using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;
        
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ShootBall();
        }
    }
    private void ShootBall()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);

    }
}
