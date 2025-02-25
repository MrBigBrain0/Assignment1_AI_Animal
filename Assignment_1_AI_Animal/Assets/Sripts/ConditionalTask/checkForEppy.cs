using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions 
{
	public class checkForEppy : ConditionTask 
	{
		public BBParameter<float> energy;

		public Blackboard agentBlackboard;

		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck() 
		{
			if(energy.value < 60)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}