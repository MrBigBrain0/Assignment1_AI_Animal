using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class PlaySoundAT : ActionTask
    {
        public string SFXName;

        protected override void OnExecute()
        {
            AudioManager.Instance.PlaySound(SFXName);
        }
        protected override string OnInit()
        {
            return null;
        }
    }
}