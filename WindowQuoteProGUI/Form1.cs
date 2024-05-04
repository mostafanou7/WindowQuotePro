using WindowQuoteProGUI.Interop;

namespace WindowQuoteProGUI
{
    public partial class Form1 : Form
    {
        iQuoteManager m_q;
        eDoorMaterial[] m_doorMaterials;
        eDoorSize[] m_doorSizes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            populateComboBoxes();

            //Create Quote Manager
            NativeImports.CreateNativeQuoteManager(out m_q);
                
            refreshQuoteList();

            //sQuote q;
            //m_q.createQuote("testQuote", "Mostafa", eDoorMaterial.Metal, eDoorSize.Small, out q);

            //sQuote[] localOutputs = null!;
            //pfnHaveQuotes pfnOutputs = (int length, sQuote[] buffers) => localOutputs = buffers;

            //m_q.getAllQuotes(pfnOutputs);

            //m_q.deleteQuote(2);

            //q.customerName = "Nouh";
            //m_q.updateQuote(q);

            //res = null!;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerName_txtBox.Text) ||
                string.IsNullOrEmpty(quoteName_txtBox.Text) ||
                    doorMaterial_cb.SelectedIndex < 0 ||
                    doorSize_cb.SelectedIndex < 0)
                return;

            m_q.createQuote(quoteName_txtBox.Text, customerName_txtBox.Text,
                m_doorMaterials[doorMaterial_cb.SelectedIndex], m_doorSizes[doorSize_cb.SelectedIndex], out sQuote qoute);

            loadQuote(qoute);

            refreshQuoteList();
        }

        private void refreshQuoteList()
        {
            sQuote[] localOutputs = null!;
            pfnHaveQuotes pfnOutputs = (int length, sQuote[] buffers) => localOutputs = buffers;

            m_q.getAllQuotes(pfnOutputs);

            listView1.Items.Clear();
            for (int i = 0; i < localOutputs.Length; i++)
            {
                ListViewItem item = new(localOutputs[i].quoteID.ToString());
                item.SubItems.Add(localOutputs[i].quoteName);
                item.SubItems.Add(localOutputs[i].customerName);
                item.SubItems.Add(localOutputs[i].doorMaterial.ToString());
                item.SubItems.Add(localOutputs[i].doorSize.ToString());
                item.SubItems.Add(localOutputs[i].price.ToString());
                listView1.Items.Add(item);
            }
        }

        private void populateComboBoxes()
        {
            m_doorMaterials = Utils.enumValues<eDoorMaterial>().ToArray();
            foreach (var m in m_doorMaterials)
            {
                doorMaterial_cb.Items.Add(m.ToString());
            }
            m_doorSizes = Utils.enumValues<eDoorSize>().ToArray();
            foreach (var s in m_doorSizes)
            {
                doorSize_cb.Items.Add(s.ToString());
            }
        }

        private void loadQuote(sQuote q)
        {
            this.ID_txtbox.Text = q.quoteID.ToString();
            this.price_txtbox.Text = q.price.ToString();
            this.quoteName_txtBox.Text = q.quoteName;
            this.customerName_txtBox.Text = q.customerName;
            this.doorMaterial_cb.SelectedIndex = (int)q.doorMaterial;
            this.doorSize_cb.SelectedIndex = (int)q.doorSize;
        }
    }
}
