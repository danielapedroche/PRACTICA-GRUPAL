using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENCarrito
    {
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double CosteTotal
        {
            get { return _costetotal; }
            set { _costetotal = value; }
        }

        private double _costetotal;
        private int _id;
        private string _nombre;

        public ENCarrito()
        {
            this._id = -1;
            this._nombre = "";
            this._costetotal = 0;
        }

        public ENCarrito(int id,string nombre, double costetotal)
        {
            this._id = id;
            this._nombre = nombre;
            this._costetotal = costetotal;
        }

        public bool createCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.createCarrito(this);
        }
        public bool readCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.readCarrito(this);
        }
        public bool updateCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.updateCarrito(this);

        }
        public bool deleteCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.deleteCarrito(this);
        }
    }
}
