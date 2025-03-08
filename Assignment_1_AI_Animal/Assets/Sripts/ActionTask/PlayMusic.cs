using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Xml.Linq;


namespace NodeCanvas.Tasks.Actions 
{

	public class PlayMusic : ActionTask 
	{
        public string MusicName;
        protected override string OnInit() 
		{
			return null;
		}

		protected override void OnUpdate()
		{
            AudioManager.Instance.PlaySound(MusicName);
        }

		protected override void OnStop() 
		{
			
		}

		protected override void OnPause() 
		{
			
		}
	}
}