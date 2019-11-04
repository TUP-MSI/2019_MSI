using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleArt.Models
{
    public class DepositoLocker{
        private int id;
        private Locker locker;
        private Ubicacion ubicacion;

        public DepositoLocker(){
        }

        public int Id { get => id; set => id = value; }
        public Locker Locker { get => locker; set => locker = value; }
        internal Ubicacion Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}