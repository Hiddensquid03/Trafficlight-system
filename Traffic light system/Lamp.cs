using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_light_system
{
    internal class Lamp
    {
        private Color m_lampColour;//light colour
        private bool m_onStatus;//on or off true = on false == off
        private Rectangle m_pos;//position

        public Lamp(Color col, int atx, int aty)
        {
            m_onStatus = false; // first the lamp is off
            m_lampColour = col; // sets colour
            m_pos = new Rectangle(atx, aty, 50, 50);
        }
        public bool lampOn
        {
            get { return m_onStatus; }
            set { m_onStatus = value; }
        }

            public void display (Graphics g)
        {
            SolidBrush myBrush;
            if (m_onStatus)
                myBrush = new SolidBrush(m_lampColour);
            else
                myBrush = new SolidBrush(Color.Gray);
            g.FillEllipse(myBrush, m_pos);
        }
        
    }
}
