//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     Do not change anything in this file because it was auto-generated by FlowCompiler.
//     See more: https://github.com/chromealex/Unity3d.UI.Windows
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Loader.Loading {

	public class LoadingScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Call the end of current function Loader.
		/// Function: Loading
		/// </summary>
		public void FlowFunctionReturn(bool reusable = false) {
			
			WindowSystem.CallFunction(this, reusable);
			
		}

		/// <summary>
		/// Call the end of current function Loader and hides current.
		/// Function: Loading
		/// </summary>
		public void FlowHideFunctionReturn(bool reusable = false) {
			
			this.Hide();
			WindowSystem.CallFunction(this, reusable);
			
		}

		/// <summary>
		/// Call the end of current function Loader and hides current and wait while it hidden.
		/// Function: Loading
		/// </summary>
		public void FlowWaitHideFunctionReturn(bool reusable = false) {
			
			this.Hide(() => {
				
				WindowSystem.CallFunction(this, reusable);
				
			});

		}

	}

}