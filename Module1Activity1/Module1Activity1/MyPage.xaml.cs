using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module1Activity1
{	
	public partial class MyPage : ContentPage
	{	
		public MyPage ()
		{
			InitializeComponent ();


		}

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

