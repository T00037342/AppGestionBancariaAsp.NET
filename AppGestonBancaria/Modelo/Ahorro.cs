using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestonBancaria.Modelo
{
    public class Ahorros : Cuentas
    {
        #region "Atributos"
        private float tasaInteres;
        #endregion

        #region "Propiedades"

        public float Tasadeinteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }
        #endregion

        #region"Constructores"

        ///<summary>
        ///Contructor por defecto  de Cuenta de Ahorros
        ///</summary>
        ///
        public Ahorros():base()
        {
            this.tasaInteres = 0 ;
        }

        public Ahorros(string cliente, string identificacion, string idCliente,double balance,float tasaInteres)
            :base( cliente,  identificacion,  idCliente, balance)
        {
            this.tasaInteres = tasaInteres;
        }

        #endregion

        #region "Metodos Sobre Escritos"

        public override string ToString()
        {
            return base.ToString() +
                   "Tasa de Interes: " + this.tasaInteres;
        }
        public override bool Equals(object obj)
        {
            Ahorros c = (Ahorros)obj;
            bool result = false;

            if (base.Equals(c) &&
               (this.tasaInteres == c.tasaInteres))
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
        public void Depositar(BalanceActual + deposito);
        public void Retirar(BalanceActual - Retiro - tasaInteres);
        #endregion

    }
}