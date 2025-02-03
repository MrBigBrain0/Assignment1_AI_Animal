using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions 
{

	public class PlayerP : ConditionTask 
	{
        protected override bool OnCheck()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                //Debug.Log("Piss");
                return true;
            }
            else return false;
        }
    }
}