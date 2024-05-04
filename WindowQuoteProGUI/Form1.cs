using WindowQuoteProGUI.Interop;

namespace WindowQuoteProGUI
{
    public partial class Form1 : Form
    {
        iQuoteManager res;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NativeImports.CreateNativeQuoteManager(out res);
            sQuote q;
            res.createQuote("testQuote", "Mostafa", eDoorMaterial.Metal, eDoorSize.Small, out q);

            sQuote[] localOutputs = null!;
            pfnHaveQuotes pfnOutputs = (int length, sQuote[] buffers) => localOutputs = buffers;

            res.getAllQuotes(pfnOutputs);

            res.deleteQuote(2);

            q.customerName = "Nouh";
            res.updateQuote(q);

            res = null!;

            Console.WriteLine(q.price);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerName_txtBox.Text) ||
                string.IsNullOrEmpty(quoteName_txtBox.Text))
                return;

        }
    }
}
