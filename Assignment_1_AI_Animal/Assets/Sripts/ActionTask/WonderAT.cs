using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions 
{

	public class WonderAT : ActionTask 
	{
        private NavMeshAgent navAgent;
        
		public float searchRaduis;
		Vector3 endingDestiniation;

		public BBParameter<float> energy;
		public BBParameter<float> energyUsage;
		public BBParameter<float> drinkCooldown;

		protected override string OnInit() 
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			Blackboard agentBlackboard = agent.GetComponent<Blackboard>();

			return null;
		}


		protected override void OnExecute() 
		{

			Vector3 walkDestination = Random.insideUnitSphere * searchRaduis;
			walkDestination += agent.transform.position;

			NavMeshHit hit;

			NavMesh.SamplePosition(walkDestination, out hit, searchRaduis, 1);
			endingDestiniation = hit.position;

            navAgent.SetDestination(hit.position);

        }

		protected override void OnUpdate() 
		{

			energy.value -= energyUsage.value * Time.deltaTime;
			drinkCooldown.value -= energyUsage.value * Time.deltaTime;
			
			if (Vector3.Distance(agent.transform.position, endingDestiniation) < 1f)
			{
				EndAction(true);
			}
			
		}

	}
}