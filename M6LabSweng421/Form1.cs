using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace M6LabSweng421
{

    public partial class Form1 : Form
    {


        private bool drawDotFlag = false;
        private bool clear = false;
        private List<Vertex> vertices = new List<Vertex>(); //store vertices
        private List<Edge> edges = new List<Edge>(); //store edges
        private Graph_Manager manager = Graph_Manager.GetInstance();
        private List<Bitmap> bmL;



        public Form1()
        {
            InitializeComponent();

            manager = Graph_Manager.GetInstance();
            bmL = new List<Bitmap>();

            Form2 form2 = new Form2(bmL);
            form2.Show();

            this.MouseClick += Form1_MouseClick; //use mouseClick event

        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (Vertex vertex in vertices)
            {
                vertex.Draw(e.Graphics);
            }
        }




        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //storing clicked coordinates
                int x_coor = e.X;
                int y_coor = e.Y;
                Vertex v = new Vertex(x_coor, y_coor);
                vertices.Add(v);


                if (vertices.Count == 2)
                {
                    int id = 0;
                    Edge nE = new Edge(id, vertices[0], vertices[1]);

                    using (Graphics g = this.CreateGraphics())
                    {

                        //v.Draw(g);
                        nE.Draw(g);
                    }
                    edges.Add(nE);


                    vertices.Clear();
                }


            }



        }



        //clicking save graph will add the graph to listbox with index
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;

            //saves the graphs current vertices and edges
            Graph nG = new Graph(k, edges);
            Graph.incrementID();    //only increment id when updating listBox

            Debug.WriteLine(Graph_Manager.GetInstance());
            Debug.WriteLine(Graph_Manager.GetInstance().Graphs);

            manager.saveGraph(nG);      //using the debugger found out that the edges are being stored here within the graph manager


            Debug.WriteLine(manager.Graphs[0].edges.Count());       //showing correct number of edges within output as well
            Debug.WriteLine(Graph_Manager.GetInstance().Graphs.IndexOf(nG)); //shows that the index is being incremented within the graph manager evert time a new graph is saved
                                                                             //updates the list of graphs whenever graph is saved
            UpdateGraphListBox();

            Bitmap gb = nG.CreateGraphBitmap(); //storing currently saved graph within a bitmap

            bmL.Add(gb);            //adding graph bitmap to list of bitmap



            clearCanvas();



            Invalidate();


        }

        public void clearCanvas()
        {
            vertices.Clear();
            edges.Clear(); 

            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < bmL.Count)
            {

                Bitmap selectedBitmap = bmL[selectedIndex];

                //get graph associated with the selected bitmap
                if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
                {
                    Graph selectedGraph = manager.Graphs[selectedIndex];


                    List<Edge> edges = selectedGraph.edges;

                    //draw new edges on bitmap
                    DrawEdgesOnBitmap(selectedBitmap, edges);

                    //update picturebox
                    pictureBox1.Image = selectedBitmap;
                }
            }


        }

        private void DrawEdgesOnBitmap(Bitmap bitmap, List<Edge> edges)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {



                //draw edges ontobitmap
                foreach (Edge edge in edges)
                {
                    edge.Draw(g);
                }
            }
        }


        //not importnatn
        private void Form1_Load(object sender, EventArgs e)
        {

        }











        //updates list box with new graph
        public void UpdateGraphListBox()
        {
            listBox1.Items.Clear();

            //add id of graph to listbox

            foreach (Graph graph in manager.Graphs)
            {
                listBox1.Items.Add($"Graph {graph.ID}");
            }
            
        }


        public int GetSelectedIndex()
        {
            return listBox1.SelectedIndex;
        }










        //non imponrta nt
        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            Graph nU = new Graph(k, edges);


            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
            {
                pictureBox1.Image = bmL[listBox1.SelectedIndex];

            }

        }

        //list box that tracks all graphs 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCanvas();




        }

        bool createG = false;

        //creates graph based on whats picked in listbox
        private void button3_Click_1(object sender, EventArgs e)
        {


            //get the selected index and update the bitmap
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
            {
                
                pictureBox1.Image = bmL[listBox1.SelectedIndex];

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
            {

                Graph selectedGraph = manager.Graphs[selectedIndex];



                // Create a new graph object
                Graph copiedGraph = new Graph(selectedGraph.ID, selectedGraph.edges);
                Graph.incrementID();    //only update ID when adding to listBox

                manager.Graphs.Add(copiedGraph);

                //make a copy of the bitmap selected
                Bitmap copyBitmap = new Bitmap(bmL[selectedIndex]);

                //add bitmap to bitmap list
                bmL.Add(copyBitmap);


                UpdateGraphListBox();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}