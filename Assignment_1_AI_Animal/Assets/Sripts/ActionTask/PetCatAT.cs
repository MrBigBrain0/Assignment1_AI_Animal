using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions 
{

	public class PetCatAT : ActionTask
	{
		public string purring;
		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
			EndAction(true);
		}

		protected override void OnUpdate()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				//AudioManagement.Instance.PlaySound(purring);
				EndAction(true);
			}
		}
	}
}