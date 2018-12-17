using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WindowsFormsApplication1.DataStructure;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
            KeyDown += new KeyEventHandler(form_game_KeyDown);
        }
        int x, y, a, b;int count = 0;
        
       public void form_game_KeyDown(object sender, KeyEventArgs e)
        {
            a = x = pictureBox1.Location.X;
            b = y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right) {x += 10; count++; }
            else if (e.KeyCode == Keys.Left) {x -= 10; count++; }
            else if (e.KeyCode == Keys.Up) { y -= 10; count++; }
            else if (e.KeyCode == Keys.Down) { y += 10; count++; }

            pictureBox1.Location = new Point(x, y);
            pictureBox3.Location = new Point(x, y);
            // if player reach to finish poin
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("Congratulations You have reached the end of the level \n" + "your path cost is " + count, "Congratulations",
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                int m = pictureBox2.Location.X;
                int n = pictureBox2.Location.Y;
                pictureBox1.Location = new Point(m, n);
                pictureBox3.Location = new Point(m, n);
                pictureBox2.Visible = true;
                
            }
           
           collision();
         
        }
        // to check collision between  picturebox1(player) and any label
        #region
        void collision()
        {
            
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                
                MessageBox.Show("you hit the wall", "Oops",MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                pictureBox1.Location = new Point(a, b);
                  pictureBox1.Refresh();
               

            }
            if (pictureBox1.Bounds.IntersectsWith(label2.Bounds))
            {
               MessageBox.Show("you hit the wall", "Oops",MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label3.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label4.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label6.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label7.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label8.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label9.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label10.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label11.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label12.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label13.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label14.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label15.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label16.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label17.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label18.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label19.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label20.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label21.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label22.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label23.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label24.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            }  if (pictureBox1.Bounds.IntersectsWith(label25.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            }
            if (pictureBox1.Bounds.IntersectsWith(label26.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label28.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            }  if (pictureBox1.Bounds.IntersectsWith(label29.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label30.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label31.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label32.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label34.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            } if (pictureBox1.Bounds.IntersectsWith(label35.Bounds))
            {
                MessageBox.Show("you hit the wall", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(a, b);
                pictureBox1.Refresh();
            }

        }
        #endregion
        bool collision1()
        {

            if (pictureBox3.Bounds.IntersectsWith(label1.Bounds))
            {

                return true;


            }
            else if (pictureBox3.Bounds.IntersectsWith(label2.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label3.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label4.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label5.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label6.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label7.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label8.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label9.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label10.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label11.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label12.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label13.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label14.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label15.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label16.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label17.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label18.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label19.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label20.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label21.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label22.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label23.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label24.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label25.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label26.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label28.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label29.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label30.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label31.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label32.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label34.Bounds))
            {
                return true;
            }
            else if (pictureBox3.Bounds.IntersectsWith(label35.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void Form1_Load(object sender, EventArgs e) { }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)

        {
           
        }
        private bool check(myTree tree, myNode node)
        {
            bool c=true;
            foreach (myNode n in tree.nodes)
            {
                if (n.X == node.X && n.Y == node.Y)
                {
                    c= false;
                }
                
                
            }
            return c;
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void label27_Click(object sender, EventArgs e)//try again
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label37_Click(object sender, EventArgs e)//dfs
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree DFS = new myTree(root);
            DFS.CurrentNode = root;

            for (int i = 0; i < DFS.nodes.Count; i++)
            {

                DFS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(DFS.CurrentNode.X, DFS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = DFS.CurrentNode;
                    break;
                }


                myNode node1 = new myNode(DFS.CurrentNode.X + 10, DFS.CurrentNode.Y);
                pictureBox3.Location = new Point(node1.X, node1.Y);

                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = DFS.CurrentNode;
                    node1.level = DFS.CurrentNode.level + 1;

                    if (check(DFS, node1))
                        DFS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(DFS.CurrentNode.X - 10, DFS.CurrentNode.Y);
                pictureBox3.Location = new Point(node2.X, node2.Y);

                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = DFS.CurrentNode;
                    node2.level = DFS.CurrentNode.level + 1;

                    if (check(DFS, node2))
                        DFS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(DFS.CurrentNode.X, DFS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node3.X, node3.Y);

                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = DFS.CurrentNode;
                    node3.level = DFS.CurrentNode.level + 1;

                    if (check(DFS, node3))
                        DFS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(DFS.CurrentNode.X, DFS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node4.X, node4.Y);

                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = DFS.CurrentNode;
                    node4.level = DFS.CurrentNode.level + 1;

                    if (check(DFS, node4))
                        DFS.nodes.Add(node4);
                }
                newNodes.Add(node4);
                DFS.CurrentNode.expand(newNodes);
                DFS.CurrentNode = DFS.nodes[i + 1];

            }

            Stack path = new Stack();
            bool b = true;
            while (b)
            {

                path.Push(gool);
                gool = gool.Parent;
                if (gool == root)
                    b = false;
            }
            int time = 0;
            for (int i = 0; i < DFS.nodes.Count; i++)
            {
                if (DFS.nodes[i].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            MessageBox.Show("Congratolation \n your path cost = " + PathCost + " \n your space = " + DFS.nodes.Count + "\n your time = " + time);
        }

        private void label33_Click(object sender, EventArgs e)//bfs
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree BFS = new myTree(root);
            BFS.CurrentNode = root;
            //while (!isGool)
            //{
            for (int i = 0; i < BFS.nodes.Count; i++)
            {

                BFS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(BFS.CurrentNode.X, BFS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = BFS.CurrentNode;
                    break;
                }

                // EXBAND NEW NODES
                myNode node1 = new myNode(BFS.CurrentNode.X + 10, BFS.CurrentNode.Y);
                pictureBox3.Location = new Point(node1.X, node1.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = BFS.CurrentNode;
                    node1.level = BFS.CurrentNode.level + 1;
                    //if(!BFS.nodes.Contains(node1))
                    if (check(BFS, node1))
                        BFS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(BFS.CurrentNode.X, BFS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node2.X, node2.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = BFS.CurrentNode;

                    node2.level = BFS.CurrentNode.level;
                    //if (!BFS.nodes.Contains(node2))
                    if (check(BFS, node2))
                        BFS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(BFS.CurrentNode.X - 10, BFS.CurrentNode.Y);
                pictureBox3.Location = new Point(node3.X, node3.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = BFS.CurrentNode;
                    node3.level = BFS.CurrentNode.level + 1;
                    //if (!BFS.nodes.Contains(node3))
                    if (check(BFS, node3))
                        BFS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(BFS.CurrentNode.X, BFS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node4.X, node4.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = BFS.CurrentNode;
                    node4.level = BFS.CurrentNode.level + 1;

                    //if (!BFS.nodes.Contains(node4))
                    if (check(BFS, node4))
                        BFS.nodes.Add(node4);
                }
                newNodes.Add(node4);
                BFS.CurrentNode.expand(newNodes);
                // MessageBox.Show(BFS.CurrentNode.X.ToString());

                BFS.CurrentNode = BFS.nodes[i + 1];

            }
            Stack path = new Stack();
            bool b = true;
            while (b)
            {

                path.Push(gool);
                gool = gool.Parent;
                if (gool == root)
                    b = false;
            }
            int time = 0;
            for (int i = 0; i < BFS.nodes.Count; i++)
            {
                if (BFS.nodes[i].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }

            MessageBox.Show("Congratolation \n your path cost = " + PathCost + " \n your space = " + BFS.nodes.Count + "\n your time = " + time);

        }

        private void label36_Click(object sender, EventArgs e)//dls
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree DlS = new myTree(root);
            DlS.CurrentNode = root;

            for (int i = 0; i < 50; i++)
            {

                DlS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(DlS.CurrentNode.X, DlS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = DlS.CurrentNode;
                    break;
                }


                myNode node1 = new myNode(DlS.CurrentNode.X + 10, DlS.CurrentNode.Y);
                pictureBox3.Location = new Point(node1.X, node1.Y);

                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = DlS.CurrentNode;
                    node1.level = DlS.CurrentNode.level + 1;

                    if (check(DlS, node1))
                        DlS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(DlS.CurrentNode.X - 10, DlS.CurrentNode.Y);
                pictureBox3.Location = new Point(node2.X, node2.Y);

                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = DlS.CurrentNode;
                    node2.level = DlS.CurrentNode.level + 1;

                    if (check(DlS, node2))
                        DlS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(DlS.CurrentNode.X, DlS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node3.X, node3.Y);

                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = DlS.CurrentNode;
                    node3.level = DlS.CurrentNode.level + 1;

                    if (check(DlS, node3))
                        DlS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(DlS.CurrentNode.X, DlS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node4.X, node4.Y);

                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = DlS.CurrentNode;
                    node4.level = DlS.CurrentNode.level + 1;

                    if (check(DlS, node4))
                        DlS.nodes.Add(node4);
                }
                newNodes.Add(node4);
                DlS.CurrentNode.expand(newNodes);
                DlS.CurrentNode = DlS.nodes[i + 1];

            }

            Stack path = new Stack();
            bool b = true;
            while (b)
            {

                if (gool == root)
                    b = false;
                MessageBox.Show("sorry can't reach the goal☺");
                break;
            }
            int time = 0;
            for (int i = 0; i < DlS.nodes.Count; i++)
            {
                if (DlS.nodes[i].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            if (b == true)
                MessageBox.Show("Congratolation \n your path cost = " + PathCost + " \n your space = " + DlS.nodes.Count + "\n your time = " + time);
        }

        private void label38_Click(object sender, EventArgs e)//ids
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree IDS = new myTree(root);
            IDS.CurrentNode = root;
            int z = 367; bool b = true; int i = 0;
            for (int iz = 0; iz < z; iz++)
            {

                IDS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(IDS.CurrentNode.X, IDS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = IDS.CurrentNode;
                    break;
                }


                myNode node1 = new myNode(IDS.CurrentNode.X + 10, IDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node1.X, node1.Y);

                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = IDS.CurrentNode;
                    node1.level = IDS.CurrentNode.level + 1;

                    if (check(IDS, node1))
                        IDS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(IDS.CurrentNode.X - 10, IDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node2.X, node2.Y);

                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = IDS.CurrentNode;
                    node2.level = IDS.CurrentNode.level + 1;

                    if (check(IDS, node2))
                        IDS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(IDS.CurrentNode.X, IDS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node3.X, node3.Y);

                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = IDS.CurrentNode;
                    node3.level = IDS.CurrentNode.level + 1;

                    if (check(IDS, node3))
                        IDS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(IDS.CurrentNode.X, IDS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node4.X, node4.Y);

                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = IDS.CurrentNode;
                    node4.level = IDS.CurrentNode.level + 1;

                    if (check(IDS, node4))
                    {
                        IDS.nodes.Add(node4);

                    } 
                }
                newNodes.Add(node4);
                IDS.CurrentNode = IDS.CurrentNode.expand(newNodes);
                IDS.CurrentNode = IDS.nodes[iz + 1];
                if (i == z - 1 && i < IDS.nodes.Count)
                { ++z; iz = 0; } i++;
                
            }

            Stack path = new Stack();
            
            while (b)
            {
                path.Push(gool);
                gool = gool.Parent;
                if (gool == root)
                    b = false;
                break;
            }
            int time = 0;
            for (int iz = 0; iz < IDS.nodes.Count; iz++)
            {
                if (IDS.nodes[iz].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            } if (b == true)
                MessageBox.Show("Congratolation \n your path cost = " + (Math.Abs((PathCost + IDS.nodes.Count) * (z - IDS.nodes.Count))) + " \n your space = " + IDS.nodes.Count + "\n your time = " + time);
        }

        private void label39_Click(object sender, EventArgs e)//bds
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree BDS = new myTree(root);
            BDS.CurrentNode = root;

            for (int i = 0; i < BDS.nodes.Count; i++)
            {

                BDS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(BDS.CurrentNode.X, BDS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = BDS.CurrentNode;
                    break;
                }


                myNode node1 = new myNode(BDS.CurrentNode.X + 10, BDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node1.X, node1.Y);

                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = BDS.CurrentNode;
                    node1.level = BDS.CurrentNode.level + 1;

                    if (check(BDS, node1))
                        BDS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(BDS.CurrentNode.X - 10, BDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node2.X, node2.Y);

                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = BDS.CurrentNode;
                    node2.level = BDS.CurrentNode.level + 1;

                    if (check(BDS, node2))
                        BDS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(BDS.CurrentNode.X, BDS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node3.X, node3.Y);

                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = BDS.CurrentNode;
                    node3.level = BDS.CurrentNode.level + 1;

                    if (check(BDS, node3))
                        BDS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(BDS.CurrentNode.X, BDS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node4.X, node4.Y);

                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = BDS.CurrentNode;
                    node4.level = BDS.CurrentNode.level + 1;

                    if (check(BDS, node4))
                        BDS.nodes.Add(node4);
                }
                newNodes.Add(node4);
                BDS.CurrentNode = BDS.nodes[i + 1];
                BDS.CurrentNode.expand(newNodes);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
                {

                    gool = BDS.CurrentNode;
                    break;
                }


                myNode node5 = new myNode(BDS.CurrentNode.X - 10, BDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node5.X, node5.Y);

                if (collision1())
                {
                    node5 = null;
                }
                else
                {
                    node5.Parent = BDS.CurrentNode;
                    node5.level = BDS.CurrentNode.level - 1;

                    if (check(BDS, node5))
                        BDS.nodes.Add(node5);
                }
                newNodes.Add(node5);
                myNode node6 = new myNode(BDS.CurrentNode.X + 10, BDS.CurrentNode.Y);
                pictureBox3.Location = new Point(node6.X, node6.Y);

                if (collision1())
                {
                    node6 = null;
                }
                else
                {
                    node6.Parent = BDS.CurrentNode;
                    node6.level = BDS.CurrentNode.level - 1;

                    if (check(BDS, node6))
                        BDS.nodes.Add(node6);
                }
                newNodes.Add(node2);
                myNode node7 = new myNode(BDS.CurrentNode.X, BDS.CurrentNode.Y - 10);
                pictureBox3.Location = new Point(node7.X, node7.Y);

                if (collision1())
                {
                    node7 = null;
                }
                else
                {
                    node7.Parent = BDS.CurrentNode;
                    node7.level = BDS.CurrentNode.level - 1;

                    if (check(BDS, node7))
                        BDS.nodes.Add(node7);
                }
                newNodes.Add(node7);
                myNode node8 = new myNode(BDS.CurrentNode.X, BDS.CurrentNode.Y + 10);
                pictureBox3.Location = new Point(node8.X, node8.Y);

                if (collision1())
                {
                    node8 = null;
                }
                else
                {
                    node8.Parent = BDS.CurrentNode;
                    node8.level = BDS.CurrentNode.level - 1;

                    if (check(BDS, node8))
                        BDS.nodes.Add(node8);
                }
                newNodes.Add(node8);
                BDS.CurrentNode = BDS.nodes[i + 1];
                BDS.CurrentNode.expand(newNodes);
            }

            Stack path = new Stack();
            bool b = true;
            while (b)
            {

                path.Push(gool);
                gool = gool.Parent;
                if (gool == root)
                    b = false;
            }
            int time = 0;
            for (int i = 0; i < BDS.nodes.Count; i++)
            {
                if (BDS.nodes[i].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            MessageBox.Show("Congratolation \n your path cost = " + PathCost + " \n your space = " + BDS.nodes.Count + "\n your time = " + time);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            myNode gool = new myNode(0, 0);
            bool isGool = pictureBox1.Location.X == pictureBox2.Location.X ? true : false;
            myNode root = new myNode(pictureBox1.Location.X, pictureBox1.Location.Y);
            root.level = 0;
            myTree UCS = new myTree(root);
            UCS.CurrentNode = root;
            //while (!isGool)
            //{
            for (int i = 0; i < UCS.nodes.Count; i++)
            {

                UCS.CurrentNode.Visited = true;
                List<myNode> newNodes = new List<myNode>();
                pictureBox3.Location = new Point(UCS.CurrentNode.X, UCS.CurrentNode.Y);

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                {

                    gool = UCS.CurrentNode;
                    break;
                }

                // EXBAND NEW NODES
                myNode node1 = new myNode(UCS.CurrentNode.X + 10, UCS.CurrentNode.Y);
                node1.cost = 1;
                pictureBox3.Location = new Point(node1.X, node1.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node1 = null;
                }
                else
                {
                    node1.Parent = UCS.CurrentNode;
                    node1.level = UCS.CurrentNode.level + 1;
                    //if(!BFS.nodes.Contains(node1))
                    if (check(UCS, node1))
                        UCS.nodes.Add(node1);
                }
                newNodes.Add(node1);
                myNode node2 = new myNode(UCS.CurrentNode.X, UCS.CurrentNode.Y + 10);
                node2.cost = 1;
                pictureBox3.Location = new Point(node2.X, node2.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node2 = null;
                }
                else
                {
                    node2.Parent = UCS.CurrentNode;

                    node2.level = UCS.CurrentNode.level;
                    //if (!BFS.nodes.Contains(node2))
                    if (check(UCS, node2))
                        UCS.nodes.Add(node2);
                }
                newNodes.Add(node2);
                myNode node3 = new myNode(UCS.CurrentNode.X - 10, UCS.CurrentNode.Y);
                node3.cost = 1;
                pictureBox3.Location = new Point(node3.X, node3.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node3 = null;
                }
                else
                {
                    node3.Parent = UCS.CurrentNode;
                    node3.level = UCS.CurrentNode.level + 1;
                    //if (!BFS.nodes.Contains(node3))
                    if (check(UCS, node3))
                        UCS.nodes.Add(node3);
                }
                newNodes.Add(node3);
                myNode node4 = new myNode(UCS.CurrentNode.X, UCS.CurrentNode.Y - 10);
                node4.cost = 1;
                pictureBox3.Location = new Point(node4.X, node4.Y);
                // System.Threading.Thread.Sleep(600);
                if (collision1())
                {
                    node4 = null;
                }
                else
                {
                    node4.Parent = UCS.CurrentNode;
                    node4.level = UCS.CurrentNode.level + 1;

                    //if (!BFS.nodes.Contains(node4))
                    if (check(UCS, node4))
                        UCS.nodes.Add(node4);
                }
                newNodes.Add(node4);
                UCS.CurrentNode.expand(newNodes);
                // MessageBox.Show(BFS.CurrentNode.X.ToString());

                UCS.CurrentNode = UCS.nodes[i + 1];

            }
            Stack path = new Stack();
            bool b = true;
            while (b)
            {

                path.Push(gool);
                gool = gool.Parent;
                if (gool == root)
                    b = false;
            }
            int time = 0;
            for (int i = 0; i < UCS.nodes.Count; i++)
            {
                if (UCS.nodes[i].Visited == true)
                {
                    time++;
                }
            }
            int PathCost = path.Count;
            while (path.Count != 0)
            {
                myNode temp = (myNode)path.Pop();
                pictureBox1.Location = new Point(temp.X, temp.Y);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }

            MessageBox.Show("Congratolation \n your path cost = " + PathCost + " \n your space = " + UCS.nodes.Count + "\n your time = " + time);

        }
        }
    }

