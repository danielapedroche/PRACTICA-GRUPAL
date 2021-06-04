using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENMenu
    {
        private int id;
        private string nombre;
        private float precio;
        private int pedido;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        public ENMenu()
        {
            id = 0;
            nombre = "";
            precio = 0;
            pedido = 0;
        }
        public ENMenu(int id, string nombre, float precio, int pedido)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.pedido = pedido;
        }
        public ENMenu(ENMenu producto)
        {
            this.id = producto.id;
            this.nombre = producto.nombre;
            this.precio = producto.precio;
            this.pedido = producto.pedido;
        }
        public bool create()
        {
            CADMenu cad = new CADMenu();
            return cad.create(this);
        }
        public bool update()
        {
            CADMenu cad = new CADMenu();
            return cad.update(this);
        }
        public bool delete()
        {
            CADMenu cad = new CADMenu();
            return cad.delete(this);
        }
        public bool read()
        {
            CADMenu cad = new CADMenu();
            return cad.read(this);
        }
    }
}
