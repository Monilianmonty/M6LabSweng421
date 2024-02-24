using System;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace M6LabSweng421
{
    public class Vertex: Control 
    {

        public static int lastID = 0;

        
        public int ID { get; set; }
        public int x_coordinate { get; set; }
        public int y_coordinate { get; set; }
        
        public Vertex(int x_coordinate, int y_coordinate)
        {
            this.ID = ++lastID;    
            this.x_coordinate = x_coordinate;
            this.y_coordinate = y_coordinate;



            Size = new Size(20, 20);

        }

       
        

        public void Draw(Graphics g)
        {
           
            
            Brush brush = Brushes.Black;
            int dotSize = 5; 

            //draw dot for x and y
           g.FillEllipse(brush, x_coordinate - dotSize / 2, y_coordinate - dotSize / 2, dotSize, dotSize);
        }

    }

    


    public class Edge : Control
    {

        private static int lastID = 0;

        public int ID { get; set; }
        public Vertex from_vertex { get; set; }
        public Vertex to_vertex { get; set; }

        public Edge(int edge_ID, Vertex from_vertex, Vertex to_vertex)
        {

            this.ID = ++lastID;  

            this.from_vertex = from_vertex;
            this.to_vertex = to_vertex;


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            Graphics g = e.Graphics;

            
            Pen pen = new Pen(Color.Black, 2);

            // center 
            int cx = Width / 2;
            int cy = Height / 2;

            
            g.FillEllipse(Brushes.Black, cx - 5, cy - 5, 10, 10);

           
            pen.Dispose();
        }

        

        public void Draw(Graphics g)
        {
            
            Pen pen = new Pen(Color.Black, 2);
           
            //draw edge using vertices
            g.DrawLine(pen, from_vertex.x_coordinate, from_vertex.y_coordinate, to_vertex.x_coordinate, to_vertex.y_coordinate);

            
            pen.Dispose();
        }

    }

    public class Graph
    {

        private static int lastID = 1;
        public int ID { get; set; }
        
        public List<Edge> edges { get; set; }

      


        public Graph(int ID,List<Edge> e ) 
        {
            
            this.ID = lastID;
            
            this.edges = e;

          

        }

        public int id
        {
            get { return ID; }
            set { ID = value; }
        
        }

        public static void incrementID()
        {
            lastID++;
        }

        public Bitmap CreateGraphBitmap()
        {
            //width and height of bitmap
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;

            //create map
            Bitmap bitmap = new Bitmap(width, height);

           
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                
                g.Clear(Color.Beige); 

                //draw edges of bitmap
                foreach (Edge edge in edges)
                {
                    edge.Draw(g); //draw each edge onto bitmap
                }
            }

            return bitmap;
        }



        public void print(Graphics g)
        {
           
            foreach(Edge edge in edges)
            {
                edge.Draw(g);               
            }

        }

        

        




    }


    public class Graph_Manager
    {

        private static Graph_Manager instance;
        public List<Graph> graphs { get; set; }

        private Graph_Manager()
        {
            graphs = new List<Graph>();

        }

        //getter for list of graphs
        public List<Graph> Graphs
        {
            get { return graphs; }
        }

        public static Graph_Manager GetInstance()
        {
            if (instance == null)
            {
                instance = new Graph_Manager();
            }
            return instance;
        }

       


        //add graph
        public void saveGraph(Graph g)
        {

            graphs.Add(g);

        }






    }

    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }





        internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MultiFormContext(new Form2()));
        }
    }
}