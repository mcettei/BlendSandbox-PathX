using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace PathX_Sandbox
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

        private Storyboard caseToSpec;
        private Storyboard othersToCase;
        private Storyboard specMiniAppear;
        private Storyboard closeSpecMini;
        private Storyboard specMiniGrow;

		public MainWindow()
		{
			this.InitializeComponent();


            this.caseToSpec = (Storyboard)FindResource("CaseToSpecimen");
            this.othersToCase = (Storyboard)FindResource("OthersToCase");
            this.specMiniAppear = (Storyboard)FindResource("SpecMiniAppear");
            this.closeSpecMini = (Storyboard)FindResource("CloseSpecMini");
            this.specMiniGrow = (Storyboard)FindResource("SpecMiniGrow");
			// Insert code required on object creation below this point.
		}

		private void btn_KeyBoard_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Help_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Website_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Contact_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Legacy_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Dashboard_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_TopMenu_Pathologist_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_TopMenu_LabTech_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_TopMenu_Transcription_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_TopMenu_Coding_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_TopMenu_Admin_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Patients_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Cases_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Specimens_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Printing_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Imaging_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_SignOut_Click(object sender, RoutedEventArgs e)
		{

		}

		private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
            // TODO: Add event handler implementation here.
            if (e.AddedItems.Contains(tabSpec))
            {
                if (e.RemovedItems.Contains(tabTests))
                {
                    this.specMiniGrow.Begin();
                }
                else
                {
                    //this.caseMiniIn.Begin();
                    this.caseToSpec.Begin();
                    this.SpecMini.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            else if (e.AddedItems.Contains(tabTests))
            {
                if (e.RemovedItems.Contains(tabCase))
                {
                    //this.CaseMini.Visibility = System.Windows.Visibility.Visible;
                    this.caseToSpec.Begin();
                    
                }

                this.specMiniAppear.Begin();
                //this.SpecMini.Visibility = System.Windows.Visibility.Visible;
            }
            else if (e.AddedItems.Contains(tabCase))
            {
                this.SpecMini.Visibility = System.Windows.Visibility.Collapsed;
                //this.caseMiniOut.Begin();
                this.closeSpecMini.Begin();
                this.othersToCase.Begin();
            }
            else if (e.AddedItems.Contains(tabPatient))
            {
                if (e.RemovedItems.Contains(tabTests))
                {
                    //run animation?
                    this.closeSpecMini.Begin();
                }
                else if (e.RemovedItems.Contains(tabCase))
                {
                    this.SpecMini.Visibility = System.Windows.Visibility.Collapsed;
                    //this.CaseMini.Visibility = System.Windows.Visibility.Visible;
                    this.caseToSpec.Begin();
                }
            }
        }
	}
}