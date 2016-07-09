using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KonomiApp.Views
{
    public partial class xBarCodeScanView : ContentView
    {
        public xBarCodeScanView()
        {
            InitializeComponent();
        }

        public async void OnClickScan(Object sender, EventArgs args)
        {
            var scanResult = await Acr.BarCodes.BarCodes.Instance.Read();
            if (!scanResult.Success)
            {
            }
            else
            {  
                barCode.Text = scanResult.Code;
                
            }
        }
    }
}
