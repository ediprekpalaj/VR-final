using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class ZombieChaser : MonoBehaviour
{
    private Rigidbody rb;
    public Transform playerTransform;
    public float speed = 3.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Disable the NavMeshAgent component if it's not needed.
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.enabled = false;
        }
    }

    void FixedUpdate()
    {
        // Calculate the direction vector from the zombie to the player.
        Vector3 direction = (playerTransform.position - rb.position).normalized;
        
        // Calculate the new position the zombie should move to.
        Vector3 movePosition = rb.position + direction * speed * Time.fixedDeltaTime;
        
        // Move the zombie to the new position.
        rb.MovePosition(movePosition);
        
        // Optionally, make the zombie face the player.
        // Quaternion lookRotation = Quaternion.LookRotation(direction);
        // rb.MoveRotation(Quaternion.Slerp(rb.rotation, lookRotation, Time.fixedDeltaTime * rotationSpeed));
    }
}
