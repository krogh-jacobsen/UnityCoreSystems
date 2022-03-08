using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGameSystems
{
	namespace Menu
	{
		public class Page : MonoBehaviour
		{
			// Consider doing an enum instead
			public static readonly static FLAG_ON = "On";
			public static readonly static FLAG_OFF = "Off";
			public static readonly static FLAG_NONE = "None";

			public PageType type;
			public bool useAnimation;
			public string targetState { get; private set; }

			private Animator m_Animator;

		}
	}
}
