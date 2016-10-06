using System;
using AxAgentObjects;
using System.Collections;
using System.Collections.Generic;

namespace AgentTryout
{
	public class AgentController : IDisposable
	{
		// Agent variable.
		private AgentObjects.IAgentCtlCharacterEx agentChar;

		// Name of the initialized character.
		private string characterName;

		// Balloon constants
		private const short BalloonOn = 1;
		private const short SizeToText = 2;
		private const short AutoHide = 4;
		private const short AutoPace = 8;

		public AgentController(AxAgentObjects.AxAgent agentHost, 
			string character)
		{
			agentHost.Characters.Load(character, null);
			agentChar = agentHost.Characters[character];

			characterName = character;

			// You could put your own options in this menu, if desired.
			agentChar.AutoPopupMenu = false;

			// Set balloon style.
			agentChar.Balloon.Style = agentChar.Balloon.Style | BalloonOn;
			agentChar.Balloon.Style = agentChar.Balloon.Style | SizeToText;
			agentChar.Balloon.Style = agentChar.Balloon.Style | AutoHide;		
		}

		public void Dispose()
		{
			if (agentChar.Visible)
			{
				agentChar.StopAll(null);
				agentChar.Hide(null);
			}
		}

		public void Show()
		{
			agentChar.Show(null);
		}

		public void Hide()
		{
			agentChar.Hide(null);
		}

		public void StopAll()
		{
			agentChar.StopAll(null);
		}

		public void Speak(string text)
		{
			agentChar.StopAll(null);
			agentChar.Speak(text, "");
		}

		public void Think(string text)
		{
			agentChar.StopAll(null);
			agentChar.Think(text);
		}

		public void Animate(string animation)
		{
			agentChar.StopAll(null);
			agentChar.Play(animation);
		}

		public void MoveTo(short x, short y)
		{
			agentChar.MoveTo(x, y, null);
		}

		public void GestureAt(short x, short y)
		{
			agentChar.GestureAt(x, y);
		}

        public List<string> GetAnimations()
        {
            List<string> list = new List<string>();
            foreach (string animation in agentChar.AnimationNames)
            {
                list.Add(animation);
            }
            return list;
        }
	
	}

}
