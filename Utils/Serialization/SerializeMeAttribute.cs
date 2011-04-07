/* Copyright 2010 Andreas Reiter <andreas.reiter@student.tugraz.at>, 
 *                Georg Neubauer <georg.neubauer@student.tugraz.at>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */



using System;

namespace Iaik.Utils.Serialization
{

	/// <summary>
	/// Attach to members of derived classes of AutoStreamSerializable to get them
	/// automatically serialized.
	/// </summary>
	public class SerializeMeAttribute : Attribute
	{
		private int _ordinal;
		
		/// <summary>
		/// Gets the in stream position of the attached member
		/// </summary>
		public int Ordinal
		{
			get { return _ordinal; }
		}
		
		public SerializeMeAttribute (int ordinal)
		{
			_ordinal = ordinal;
		}
	}
}
