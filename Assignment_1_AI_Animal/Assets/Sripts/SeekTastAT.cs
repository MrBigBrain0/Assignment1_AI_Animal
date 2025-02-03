using NodeCanvas.Framework;
using UnityEngine;

public class SeekTastAT : ActionTask
{
    public BBParameter<bool> hasTarget;
    public BBParameter<Vector3> targetPosition;
    public Transform target;

    protected override void OnUpdate()
    {
        hasTarget.value = target != null;
        targetPosition.value = target.position;
    }
}
