using NodeCanvas.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class PounceAT : ActionTask
{
    public BBParameter<GameObject> Dashtarget;
    public BBParameter<float> speed = 2;
    public BBParameter<float> stopDistance = 0.1f;
    public bool waitActionFinish;

    IEnumerator parabolicJump()
    {
        yield return null;
    }

    protected override string OnInit()
    {
        return null;
    }

    protected override void OnUpdate()
    {
        /*if ((agent.transform.position - Dashtarget.value.transform.position).magnitude <= stopDistance.value)
        {
            EndAction();
            return;
        }*/

        agent.transform.position = Vector3.MoveTowards(agent.transform.position, Dashtarget.value.transform.position, speed.value * Time.deltaTime);
        if (!waitActionFinish)
        {
            EndAction();
        }
    }

}
