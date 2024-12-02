using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_light_system
{
    public class Trafficlight
    {
        private Lamp m_redlamp;
        private Lamp m_yellowlamp;
        private Lamp m_greenlamp;

        public Trafficlight(int x, int y)
        {
            m_redlamp = new Lamp(Color.Red, x, y);
            m_yellowlamp = new Lamp(Color.Yellow, x, y + 50);
            m_greenlamp = new Lamp(Color.LightGreen, x, y + 100);
        }
        public int changeLights(int state)
        {
            switch(state)
            {
                case 0:
                    m_redlamp.lampOn = true;
                    m_yellowlamp.lampOn = false;
                    m_greenlamp.lampOn = false;
                    state = 1;
                    break;

                case 1:
                    m_redlamp.lampOn = true;
                    m_yellowlamp.lampOn = true;
                    m_greenlamp.lampOn = false;
                    state = 2;
                    break;
                
                case 2:
                    m_redlamp.lampOn = false;
                    m_yellowlamp.lampOn = false;
                    m_greenlamp.lampOn = true;
                    state = 3;
                    break;

                case 3:
                    m_redlamp.lampOn = false;
                    m_yellowlamp.lampOn = true;
                    m_greenlamp.lampOn = false;
                    state = 0;
                    break;
            }
            return state;
        }
        public void displayLights(Graphics g)
        {
            m_redlamp.display(g);
            m_yellowlamp.display(g);
            m_greenlamp.display(g);
        }
    }
}
