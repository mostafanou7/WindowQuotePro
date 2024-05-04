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

            sQuote[] localOutputs = null;
            pfnHaveQuotes pfnOutputs = (int length, sQuote[] buffers) => localOutputs = buffers;

            res.getAllQuotes(pfnOutputs);

            res.deleteQuote(2);

            q.customerName = "Nouh";
            res.updateQuote(q);

            Console.WriteLine(q.price);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            res.closedb();
        }
    }
}
