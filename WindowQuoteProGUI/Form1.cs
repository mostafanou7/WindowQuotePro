using WindowQuoteProGUI.Interop;

namespace WindowQuoteProGUI
{
    public partial class Form1 : Form
    {
        iQuoteManager m_q;
        eDoorMaterial[] m_doorMaterials;
        eDoorSize[] m_doorSizes;
        sQuote[] m_allQuotes;
        int m_selectedIndex = -1;
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
                m_doorMaterials[doorMaterial_cb.SelectedIndex], m_doorSizes[doorSize_cb.SelectedIndex], out sQuote quote);

            loadQuote(quote);

            refreshQuoteList();

            int index = m_allQuotes.findIndex((q) => q.quoteID == quote.quoteID);

            updateSelection(index);
        }

        private void refreshQuoteList()
        {
            pfnHaveQuotes pfnOutputs = (int length, sQuote[] buffers) => m_allQuotes = buffers;

            m_q.getAllQuotes(pfnOutputs);

            listView1.Items.Clear();
            for (int i = 0; i < m_allQuotes.Length; i++)
            {
                ListViewItem item = new(m_allQuotes[i].quoteID.ToString());
                item.SubItems.Add(m_allQuotes[i].quoteName);
                item.SubItems.Add(m_allQuotes[i].customerName);
                item.SubItems.Add(m_allQuotes[i].doorMaterial.ToString());
                item.SubItems.Add(m_allQuotes[i].doorSize.ToString());
                item.SubItems.Add(m_allQuotes[i].price.ToString());
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

        private void updateSelection(int i)
        {
            if (i < m_allQuotes.Count() && i > -1)
            {
                m_selectedIndex = i;
                listView1.Items[i].Selected = true;
                listView1.EnsureVisible(i);
                listView1.Select();
            }
        }

        private void reset()
        {
            this.ID_txtbox.Clear();
            this.price_txtbox.Clear();
            this.quoteName_txtBox.Clear();
            this.customerName_txtBox.Clear();
            this.doorMaterial_cb.SelectedIndex = -1;
            this.doorSize_cb.SelectedIndex = -1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indices = listView1.SelectedIndices;
            if (indices.Count > 0)
            {
                var index = indices[0];
                if (index > -1)
                {
                    m_selectedIndex = index;
                    loadQuote(m_allQuotes[index]);
                    return;
                }
            }
            reset();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerName_txtBox.Text)
                || string.IsNullOrEmpty(quoteName_txtBox.Text)
                || doorMaterial_cb.SelectedIndex < 0
                || doorSize_cb.SelectedIndex < 0)
                return;

            var indices = listView1.SelectedIndices;
            if (indices.Count > 0)
            {
                var index = indices[0];
                if (index > -1)
                {

                    //Find quote by id
                    m_q.getQuote(m_allQuotes[index].quoteID, out sQuote quote);

                    //Update quote
                    quote.quoteName = quoteName_txtBox.Text;
                    quote.customerName = customerName_txtBox.Text;
                    quote.doorMaterial = (eDoorMaterial)doorMaterial_cb.SelectedIndex;
                    quote.doorSize = (eDoorSize)doorSize_cb.SelectedIndex;

                    m_q.updateQuote(quote);

                    loadQuote(quote);

                    refreshQuoteList();

                    reset();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var indices = listView1.SelectedIndices;
            if (indices.Count > 0)
            {
                var index = indices[0];
                if (index > -1)
                {

                    //Find quote by id
                    m_q.deleteQuote(m_allQuotes[index].quoteID);

                    refreshQuoteList();

                    updateSelection(m_selectedIndex);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_q = null!;
        }
    }
}