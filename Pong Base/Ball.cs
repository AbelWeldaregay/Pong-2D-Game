using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ping_Pong
{
    class Ball : GameObject
    {
        protected float m_DX;
        public float DX
        {
            get { return m_DX; }
            set { m_DX = value; }
        }

        protected float m_DY;
        public float DY
        {
            get { return m_DY; }
            set { m_DY = value; }
        }
    }
}
