using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace demoGlcontrol
{
    public partial class Form1 : Form
    {
        Casa casa = new Casa(new Vector3(0,0,0),5,8,5);
        GLControl miglControl;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.miglControl = new GLControl();//inicializa
            this.miglControl.BackColor = System.Drawing.Color.CadetBlue;
            this.miglControl.Location = new System.Drawing.Point(0, 0);
            this.miglControl.Name = "miglControl";
            this.miglControl.Size = new System.Drawing.Size(this.Width, this.Height);
            this.miglControl.TabIndex = 1;
            this.miglControl.VSync = false;
            this.miglControl.Load += new System.EventHandler(this.renderCanvas_Load);
            this.miglControl.Paint += new System.Windows.Forms.PaintEventHandler(this.renderCanvas_Paint);
            this.miglControl.Resize += new System.EventHandler(glControl1_Resize);
            this.Controls.Add(this.miglControl);
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void renderCanvas_Paint(object sender, PaintEventArgs e)
        {

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            casa.dibujar();

            miglControl.SwapBuffers();
        }

        private void renderCanvas_Load(object sender, EventArgs e)
        {
            GL.ClearColor(226 / 255.0f, 223 / 255.0f, 220 / 255.0f, 0.0f);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miglControl.MakeCurrent();
            PaintEventArgs p = null;
            renderCanvas_Paint(sender, p);
            GL.End();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            int w = miglControl.Width;
            int h = miglControl.Height;
            miglControl.MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Ortho(-10.0, 10.0, -10.0, 10.0, 10.0, -10.0);
            // GL.Ortho(-50.0, 50.0, -50.0, 50.0, -100.0, 100.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.Viewport(0, 0, w, h);
            GL.End();
            miglControl.SwapBuffers();
            
        }
    }
    
}
