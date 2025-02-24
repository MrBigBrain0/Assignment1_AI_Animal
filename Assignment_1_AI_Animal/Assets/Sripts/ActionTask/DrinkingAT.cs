using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions
{

    public class DrinkingAT : ActionTask
    {

        public BBParameter<float> energy;
        public BBParameter<float> drinkCooldown;

        public Blackboard agentBlackboard;

        protected override string OnInit()
        {
            return null;
        }

        protected override void OnUpdate()
        {
            energy.value += 15;
            drinkCooldown = 60;
        }

        protected override void OnExecute()
        {
            EndAction(true);
        }
    }
}