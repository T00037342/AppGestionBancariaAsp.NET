using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestonBancaria.Modelo
{
    public class Cheques : Cuentas
    {
        #region "atributos"
        private string idTalonario;
        #endregion

        #region "Propiedades"
        public string IdTalonario
        {
            get { return idTalonario; }
            set { idTalonario = value; }
        }
        #endregion

        #region "Constrctores"

        ///<summary>
        ///Contructor por defecto  de Cuenta Cheques
        ///</summary>
        ///
        public Cheques():base()
        {
            this.idTalonario = "..." ;
        }

        public Cheques(string cliente, string identificacion, string idCliente, double balance, string idTalonario)
            : base( cliente,  identificacion,  idCliente,  balance)
        {
            this.idTalonario = idTalonario;
        }

        #endregion

        #region "Metodos Sobre Escritos"

        public override string ToString()
        {
            return base.ToString() +
                   "ID talonario: " + this.idTalonario;
        }
        public override bool Equals(object obj)
        {
            Cheques c = (Cheques)obj;
            bool result = false;

            if (base.Equals(c) &&
               (this.idTalonario == c.idTalonario))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion

        #region "Metodos"
        public void BalanceAtual(Saldo);
        public void Depositar();
        public void Retirar(BalanceActual - RetiroCheque);
        #endregion
    }
}