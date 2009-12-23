﻿#region License
//   Copyright 2009 John Sheehan
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System.Xml.Linq;

namespace RestSharp.Serializers
{
	public interface ISerializer
	{
		XDocument Serialize(object obj);
		string RootElement { get; set; }
		string Namespace { get; set; }
		DateFormat DateFormat { get; set; } // Currently unused
	}
}