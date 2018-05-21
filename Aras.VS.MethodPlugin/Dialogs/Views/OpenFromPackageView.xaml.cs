﻿//------------------------------------------------------------------------------
// <copyright file="OpenFromPackageView.xaml.cs" company="Aras Corporation">
//     © 2017-2018 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.Windows;

namespace Aras.VS.MethodPlugin.Dialogs.Views
{
	/// <summary>
	/// Interaction logic for OpenFromPackageView.xaml
	/// </summary>
	public partial class OpenFromPackageView : Window
	{
		public OpenFromPackageView()
		{
			InitializeComponent();
		}

		private void CancelClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
