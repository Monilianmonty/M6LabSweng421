using System;
using System.Drawing;
using System.Runtime.Intrinsics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace M6LabSweng421
{

    public partial class Form2 : Form
    {


        private bool drawDotFlag = false;
        private bool clear = false;
        private List<Vertex> vertices = new List<Vertex>(); //store vertices
        private List<Edge> edges = new List<Edge>(); //store edges
        private Graph_Manager manager;
        private List<Graph> graphs = new List<Graph>();


        public Form2()
        {
            InitializeComponent();

            manager = new Graph_Manager();

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
            Graph nG = new Graph(k, vertices, edges);       //at the moment that i click save graph

           
            
            manager.saveGraph(nG);      //using the debugger found out that the edges are being stored here within the graph manager

            //updates the list of graphs whenever graph is saved
            UpdateGraphListBox();

            clearCanvas();

            Invalidate();


        }

        public void clearCanvas()
        {
            vertices.Clear();
            edges.Clear(); ;

            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear = true;


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
            /*
            foreach (Graph g in graphs)
            {
                listBox1.Items.Add($"Graph {g.ID}");
            }
            */
        }













        //create graph button
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            int temp = manager.Graphs.Count;
            //check graph selection
            if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
            {

                //drawgraph
                Graph selectedGraph = manager.Graphs.ElementAt(selectedIndex);
                List<Edge> edges = selectedGraph.edges;     //for some reason the edges in selectedGraph.edges is not getting the edges at that index
                //selectedGraph.print(e.Graphics); //uses  daw print to draw a graph
                using (Graphics g = this.CreateGraphics())
                {
                    foreach (Edge edge in edges)
                    {
                        edge.Draw(g);
                    }
                }
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


            //createG = true;

            
            

        }
    }
}