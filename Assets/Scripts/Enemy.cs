using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject[] wayPoints;
    private NavMeshAgent ai;
    private int currentWayPoint;

    // Start is called before the first frame update
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        currentWayPoint = 0;
        ai.SetDestination(wayPoints[currentWayPoint].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(ai && ai.remainingDistance < 0.2f)
        {
            currentWayPoint = (currentWayPoint + 1) % wayPoints.Length;
            if(wayPoints[currentWayPoint])
                ai.SetDestination(wayPoints[currentWayPoint].transform.position);
        }
    }
}
