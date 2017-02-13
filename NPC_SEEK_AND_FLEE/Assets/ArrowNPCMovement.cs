using UnityEngine;
using UnityEngine.AI;

public class ArrowNPCMovement : MonoBehaviour
{
    public GameObject targetGameObject;
    private NavMeshAgent _navMeshAgent;
    private float runAwayMultiplier = 2;
    private float runAwayDistance;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        runAwayDistance = _navMeshAgent.stoppingDistance * runAwayMultiplier;
    }

    void Update()
    {
        var enemyPosition = targetGameObject.transform.position;
        var distanceFromEnemy = Vector3.Distance(transform.position, enemyPosition);
        if (distanceFromEnemy < runAwayDistance)
        {
            FleeFromTarget(enemyPosition);
        }
    }

    private void HeadForDestination(Vector2 destination)
    {
        _navMeshAgent.SetDestination(destination);
    }

    private void FleeFromTarget(Vector3 enemyPosition)
    {
        var fleeToPosition = Vector3.Normalize(transform.position - enemyPosition) * runAwayDistance;
        HeadForDestination(fleeToPosition);
    }
}
