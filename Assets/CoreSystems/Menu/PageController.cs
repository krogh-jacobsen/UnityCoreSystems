using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// https://youtu.be/qkKuGmGRF2k?t=1350
/// </summary>

namespace UnityGameSystems
{
    namespace Menu
    {
        public class PageController : MonoBehaviour
		{
			public static PageController instance;
			public bool debug;
			public PageType entryPage;
			public Page[] pages;

			private Hashtable m_Pages;

            #region UnityFunctions
            private void Awake()
            {
				
            }

			#endregion

//#if UNITY_EDITOR
			#region Public functions
			public void TurnPageOn(PageType _type)
            {

            }

			public void TurnPageOff(PageType _type, PageType _on = PageType.None, bool _waiForExit = false)
            {

            }
			#endregion

			#region Private functions

			private IEnumerator WaitForPageExit (PageType _on, Page _off)
            {
                yield return null;
            }

            private void RegisterAllPages(PageType _pageType)
			{

			}

			private void RegisterPage(PageType _pageType)
			{

			}
			private bool PageExists(PageType pageType)
            {
				return false;
            }

			private void GetPage(PageType _pageType)
            {

            }
			private void Log(string _msg)
            {

            }
			private void LogWarning(string _msg)
            {

            }

			#endregion
//#endif

		}
	}
}
