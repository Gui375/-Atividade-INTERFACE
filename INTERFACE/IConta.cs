namespace INTERFACE
{
    interface IConta : ICliente
    {
        double saldo { get; set; }
        string numero { get; set; }


        double calcularSaldo();
        void sacar(double valor);
        void depositar(double valor);

        void unico();   

    }
}
