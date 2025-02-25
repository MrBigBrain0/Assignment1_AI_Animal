using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions 
{

	public class MoveToTarget : ActionTask 
	{
		private NavMeshAgent navAgent;

		public float distance;
		Vector3 lastPosition;

		public BBParameter<Transform> target;

		public Blackboard agentBlackboard;

		protected override string OnInit() 
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		protected override void OnExecute() 
		{
			navAgent.destination = target.value.position;

			NavMeshHit hit;

			NavMesh.SamplePosition(target.value.position, out hit, distance, NavMesh.AllAreas);
			lastPosition = hit.position;

			navAgent.destination = lastPosition;
		}

		protected override void OnUpdate() 
		{
			
			if (Vector3.Distance(agent.transform.position, target.value.position) <= 3)
			{
				EndAction(true);
			}
		}
	}
}