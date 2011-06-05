// SetBreakpointNameCmd.cs
//  
//  Author:
//       Andreas Reiter <andreas.reiter@student.tugraz.at>
// 
//  Copyright 2011  Andreas Reiter
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
namespace Fuzzer.TargetConnectors.GDB
{
	public class SetBreakpointNameCmd : GDBCommand
	{
		/// <summary>
		/// Break address
		/// </summary>
		private ISymbol _breakSymbol;
		
		private GDBResponseHandler _rh;
		#region implemented abstract members of Fuzzer.TargetConnectors.GDB.GDBCommand
		public override GDBResponseHandler ResponseHandler 
		{
			get { return _rh; }
		}
		
		
		public override string Command 
		{
			get { return string.Format("break {0}", _breakSymbol.Symbol);} 
		}
		
		
		protected override string LogIdentifier 
		{
			get { return "CMD_break by name"; }
		}
		
		#endregion
		
		/// <summary>
		/// Constructs a new break command
		/// </summary>
		/// <param name="breakSymbol">Symbol to break at</param>
		public SetBreakpointNameCmd (ISymbol breakSymbol, SetBreakpointRH.SetBreakpointDelegate rhCb, GDBSubProcess gdbProc)
			:base(gdbProc)
		{
			_breakSymbol = breakSymbol;
			
			_rh = new SetBreakpointRH(rhCb, _gdbProc);
		}
	}
}

