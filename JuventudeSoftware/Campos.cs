using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Campos
    {
        private string _usuario;
        private string _pass;

        public string usuario
        {
            get { return this._usuario; }
            set { this._usuario = value; }
        }
        public string pass
        {
            get { return this._pass; }
            set { this._pass = value; }
        }
    }
}
