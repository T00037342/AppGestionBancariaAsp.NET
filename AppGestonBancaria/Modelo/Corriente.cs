using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestonBancaria.Modelo
{
    public class Corrientes : Cuentas
    {
        #region "Atributos"
        private float limiteCreditos;
        private float tasaInteres;
        #endregion

        #region "Propiedades"
        public float LimitesDeCreditos
        {
            get { return limiteCreditos; }
            set { limiteCreditos = value; }
        }
        public float TasaDeInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }
        #endregion

        #region "Costructores"
        ///<summary>
        ///Contructor de Cuenta Corriente
        ///</summary>
        public Corrientes():base()
        {
            this.limiteCreditos = 0;
            this.tasaInteres = 0;
        }
        public Corrientes(string cliente, string identificacion, string idcliente, double balance, float limitesDeCreditos, float tasadeinteres)
            : base( cliente,  identificacion,  idcliente,  balance)
        {
            this.limiteCreditos = limitesDeCreditos;
            this.tasaInteres = tasadeinteres;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                     "Limite de Creditos:  " + this.limiteCreditos + "\n" +
                     "Tasa de Interes:  " + this.tasaInteres;
        }

        public override bool Equals(object obj)
        {
            Corrientes c = (Corrientes)obj;
            bool result = false;

            if ((this.limiteCreditos == c.limiteCreditos) &&
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