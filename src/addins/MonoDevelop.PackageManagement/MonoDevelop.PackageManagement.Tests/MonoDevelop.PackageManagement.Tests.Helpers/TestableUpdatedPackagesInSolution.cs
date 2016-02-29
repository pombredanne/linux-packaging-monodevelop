﻿//
// TestableUpdatedPackagesInSolution.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.PackageManagement;
using MonoDevelop.Ide;

namespace MonoDevelop.PackageManagement.Tests.Helpers
{
	public class TestableUpdatedPackagesInSolution : UpdatedPackagesInSolution
	{
		public TestableUpdatedPackagesInSolution (
			IPackageManagementSolution solution,
			IRegisteredPackageRepositories registeredPackageRepositories,
			IPackageManagementEvents packageManagementEvents,
			CheckForUpdatesTaskRunner taskRunner)
			: base (
				solution,
				registeredPackageRepositories,
				packageManagementEvents,
				taskRunner)
		{
			FileExistsAction = path => {
				return true;
			};
		}

		protected override void GuiDispatch (Action action)
		{
			action.Invoke ();
		}

		public Func<string, bool> FileExistsAction;

		protected override bool FileExists (string path)
		{
			return FileExistsAction (path);
		}
	}
}

