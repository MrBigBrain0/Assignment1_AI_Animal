using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions 
{

	public class checkPlayer : ConditionTask 
	{


		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck() 
		{
			if (Input.GetKeyDown(KeyCode.Space))
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