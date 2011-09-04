// ScriptedDataGeneratorEnvironment.cs
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
using DevEck.ScriptingEngine.Environment.Basic;
using DevEck.ScriptingEngine.Environment;
using System.Collections.Generic;
namespace Fuzzer.Scripting.Environments
{
	public class ScriptedDataGeneratorEnvironment : BasicEnvironment
	{
		private Action<byte[]> _setDataCallback;
		
		private Dictionary<string, object> _scriptValues = new Dictionary<string, object>();
		
		public ScriptedDataGeneratorEnvironment (ScriptingLanguage language, Action<byte[]> setDataCallback)
            : base(language)
		{
			_setDataCallback = setDataCallback;
			
			MethodInfo setDataMethodInfo = new MethodInfo ("SetData", null, 
				new ParameterInfo (DataLoggers, typeof(byte[])));
			GlobalMethods.Add(setDataMethodInfo);
			SetMethod(setDataMethodInfo, _setDataCallback);
			
		}
	}
}
