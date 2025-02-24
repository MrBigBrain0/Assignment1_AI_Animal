using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions 
{

	public class checkForThirstCT : ConditionTask 
	{
		public BBParameter<float> energy;
		public BBParameter<float> drinkCooldown;
		public Blackboard agentblackboard;
		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck() 
		{
			if(energy.value < 100 && drinkCooldown.value <= 0)
			{
				return true;
			}
			else
			{
                return true;
            }
			
		}
	}
}