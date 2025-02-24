using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions
{

    public class EppingAT : ActionTask
    {

        public BBParameter<float> energy;

        public Blackboard agentBlackboard;

        protected override string OnInit()
        {
            return null;
        }

        protected override void OnUpdate()
        {
            energy.value += 10;
        }

        protected override void OnExecute()
        {
            EndAction(true);
        }
    }
}