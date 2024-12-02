namespace Traffic_light_system
{
    public partial class Form1 : Form
    {
        private Trafficlight m_trafficLight, m_trafficLight2;
        private int m_lightState, m_lightState2;
        public Form1()
        {
            InitializeComponent();

            m_trafficLight = new Trafficlight(10, 10);
            m_trafficLight2 = new Trafficlight(110, 10);

            m_lightState = m_trafficLight.changeLights(0);
            m_lightState2 = m_trafficLight2.changeLights(2);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs pe)
        {
            //create a local version of the graphic for picture box
            Graphics g = pe.Graphics;

            m_trafficLight.displayLights(g);
            m_trafficLight2.displayLights(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //change traffic light state 

            m_lightState = m_trafficLight.changeLights(m_lightState);
            m_lightState2 = m_trafficLight2.changeLights(m_lightState2);

            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                button1.Text = "stop";
            else
                button1.Text = "start";
        }



    }
}