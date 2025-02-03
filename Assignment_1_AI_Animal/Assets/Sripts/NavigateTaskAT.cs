
using UnityEngine;
using Unity.AI;
using NodeCanvas.Framework;
using UnityEngine.AI;

public class NavigateTaskAT : ActionTask
{
    public BBParameter<Vector3> targetPosition;
    public float sampleRate;
    public float sampleRadius;

    private NavMeshAgent navAgent;
    private Vector3 lastDestination;
    private float timeSinceLastSample;

    protected override string OnInit()
    {
        navAgent = agent.GetComponent<NavMeshAgent>();


        return null;
    }

    protected override void OnUpdate()
    {
        timeSinceLastSample += Time.deltaTime;
        if (timeSinceLastSample > sampleRate)
        {
            timeSinceLastSample = 0;

            if(lastDestination != targetPosition.value)
            {
                lastDestination = targetPosition.value;
                NavMesh.SamplePosition(targetPosition.value, out NavMeshHit hitInfo, sampleRadius, NavMesh.AllAreas);
                navAgent.SetDestination(hitInfo.position);
            }
        }
    }
}
