using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions 
{

    public class targetReachedCT : ConditionTask 
	{
        public BBParameter<GameObject> waypoint;
		public BBParameter<GameObject> cat;

        protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck() 
		{
			
			return cat == waypoint;
		}
	}
}