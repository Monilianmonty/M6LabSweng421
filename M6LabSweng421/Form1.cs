using System;
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
        private Graph_Manager manager = new Graph_Manager();
        private List<Graph> graphs = new List<Graph>();

        

        public Form1()
        {
            InitializeComponent();

            manager = new Graph_Manager();

            this.MouseClick += Form1_MouseClick; //use mouseClick event

        }

        protected void OnPaint(PaintEventArgs e, MouseEventArgs g)
        {
            base.OnPaint(e);

            Vertex v1 = new Vertex(100, 100);
            Vertex v2 = new Vertex(100, 400);
            //make an if statement to trigger this condition
            Edge e1 = new Edge(0, v1, v2);
           

            if (drawDotFlag)
            {
                v1.Draw(e.Graphics);
                e1.Draw(e.Graphics);

            }

            if (listBox1.SelectedIndex == 0)
            {
                
                int selectedIndex = listBox1.SelectedIndex;

                //check graph selection
                if (selectedIndex >= 0 && selectedIndex < manager.Graphs.Count)
                {
                    //drawgraph
                    Console.WriteLine(selectedIndex);
                    Graph selectedGraph = manager.Graphs[selectedIndex];

                    selectedGraph.print(e.Graphics); //uses print to draw a graph
                }
            }



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

            //using graphs instance to store graphs:testing due to bug with calling saved graph
            //graphs.Add(nG);

            //the manager has a list of graphs as its attribute that it manages. save graph simply adds a graph to that list of graphs
            manager.saveGraph(nG);

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


        public int GetSelectedIndex()
        {
            return listBox1.SelectedIndex;
        }










        //non imponrta nt
        private void button3_Click(object sender, EventArgs e)
        {

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

            
            createG = true; 


        }
    }
}