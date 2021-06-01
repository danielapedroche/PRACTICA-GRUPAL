using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENOferta
    {
        static private int siguientecodigo = 1;
        private int codigo;
        private string tipo;
        private string descripcion;
        private int solousuarios;
       
    
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value;  }
        }
        public int Solousuarios
        {
            get { return solousuarios; }
            set { solousuarios = value; }
        }
      
        public ENOferta()
        {
            codigo = siguientecodigo++;   
            Tipo = "";
            descripcion = "";
            solousuarios = 0;
        }
        public ENOferta(string tipo, string descripcion, int solousuarios) {
            codigo = siguientecodigo++;
            this.Tipo = tipo;
            this.Descripcion = descripcion;
            this.solousuarios = solousuarios;
        }
        public ENOferta(int codigo)
        {
            this.Codigo = codigo;
            Tipo = "";
            Descripcion = "";
            Solousuarios = 0;
        }

        public ENOferta (int codigo, string descripcion, string tipo, int solousuarios)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Tipo = tipo;
            this.Solousuarios = solousuarios;
        }
        public ENOferta (ENOferta oferta)
        {
            codigo = siguientecodigo++;
            this.Tipo = oferta.Tipo;
            this.Descripcion = oferta.Descripcion;
            this.Solousuarios = oferta.Solousuarios;
        }

        public bool delete()
        {
            CADOferta oferta = new CADOferta();
            return oferta.delete(this);
        }
        public bool create()
        {
            CADOferta oferta = new CADOferta();
           bool creado =  oferta.create(this);
            return creado;
        }

        public void read()
        {
          
            CADOferta oferta = new CADOferta();
            oferta.read(this);
        }

        public bool update()
        {
            this.Tipo = tipo;
            CADOferta oferta = new CADOferta();
            bool affected =oferta.update(this);
            return affected;
        }

        public string invitados()
        {
            
            CADOferta oferta = new CADOferta();
            return oferta.invitados(this);
        }
    }
}
