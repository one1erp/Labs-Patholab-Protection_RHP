using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using LSExtensionExplorer;


namespace Protection_RHP
{
    public partial class Form1 : UserControl, ILSXplVisualControl, ILSXplSystemControl
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void PreDisplay()
        {
   
        }



        public void BeforeFocusedNodeChange(string keyData)
        {
      //      throw new System.NotImplementedException();
        }

        public void ChangeDataExplorerView(DataExplorerViewStyles style)
        {
     //       throw new System.NotImplementedException();
        }//

        public void DataExplorerToolbarButtonClicked(ToolbarItem item)
        {
         //   throw new System.NotImplementedException();
        }

        public event ExceptionThrownEventHandler ExceptionThrown;

        public void FocusedNodeChanged(string keyData)
        {
       //     throw new System.NotImplementedException();
        }

        public string GetObjectsStaticItemText()
        {
            return "";// throw new System.NotImplementedException();
        }

        public void InitializeToolbarItemsStatus(ref Hashtable toolbarItems)
        {
         //   throw new System.NotImplementedException();
        }

        public void NeedRefresh(string keyData, params string[] parameters)
        {
       //     throw new System.NotImplementedException();
        }

        public void ProcessToolbarItemClick(ToolbarItem item)
        {
      //      throw new System.NotImplementedException();
        }

        public void SetServiceProvider(object serviceProvider)
        {
          //  throw new System.NotImplementedException();
        }

        

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblHeader.Location = new Point(Width / 2 - lblHeader.Width / 2, lblHeader.Location.Y);
         //   pictureBox1.Location = new Point(Width / 2 - pictureBox1.Width / 2, pictureBox1.Location.Y);
            
        }
    }
}
