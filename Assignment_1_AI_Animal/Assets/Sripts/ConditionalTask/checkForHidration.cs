using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions 
{

	public class checkForHidration : ConditionTask 
	{
		public BBParameter<float> energy;
		public BBParameter<float> drinkCooldown;

		public Blackboard agentBlackboard;
		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck() 
		{
			if (energy.value >= 120)
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